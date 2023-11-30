CREATE SCHEMA `clothe_database` ;
USE `clothe_database`;
CREATE TABLE `User` (
	`ID` INT NOT NULL AUTO_INCREMENT,
	`Name` VARCHAR(255) NOT NULL,
	`Address` VARCHAR(255),
	`Phone` VARCHAR(15) NOT NULL,
	`Email` VARCHAR(255) NOT NULL,
	`Role` INT NOT NULL DEFAULT '1',
	`CCCD` VARCHAR(50) NOT NULL,
	`active` INT NOT NULL DEFAULT '1',
	PRIMARY KEY (`ID`)
);

CREATE TABLE `role` (
	`ID` INT NOT NULL AUTO_INCREMENT,
	`Name` VARCHAR(255) NOT NULL,
	`active` INT NOT NULL DEFAULT '1',
	PRIMARY KEY (`ID`)
);

CREATE TABLE `authority` (
	`ID` INT NOT NULL AUTO_INCREMENT,
	`Name` VARCHAR(255) NOT NULL,
	PRIMARY KEY (`ID`)
);

CREATE TABLE `authority_detail` (
	`ID` INT NOT NULL AUTO_INCREMENT,
	`ID_role` INT NOT NULL,
	`ID_authority` INT NOT NULL,
	PRIMARY KEY (`ID`)
);

CREATE TABLE `Account` (
	`ID` INT NOT NULL AUTO_INCREMENT,
	`ID_user` INT NOT NULL,
	`UserName` VARCHAR(50) NOT NULL,
	`Password` VARCHAR(50) NOT NULL,
	`Date_Created` DATETIME,
	`Date_Edited` DATETIME,
	`Last_Login` DATETIME,
	`active` INT NOT NULL DEFAULT '1',
	PRIMARY KEY (`ID`)
);

CREATE TABLE `Product` (
	`ID` INT NOT NULL AUTO_INCREMENT,
	`Name` VARCHAR(255) NOT NULL,
	`Price` INT NOT NULL,
	`Brand` INT NOT NULL,
	`Category` INT NOT NULL,
	`Quantity` INT NOT NULL,
	`Image` BLOB,
	`Description` VARCHAR(255),
	`Created_by` INT,
	`Created_Date` DATETIME,
	`Edited_Date` DATETIME,
	`Edited_by` INT,
	`active` INT NOT NULL DEFAULT '1',
	PRIMARY KEY (`ID`)
);

CREATE TABLE `Brand` (
	`ID` INT NOT NULL AUTO_INCREMENT,
	`Name` VARCHAR(255) NOT NULL,
	`Description` VARCHAR(255),
	`active` INT NOT NULL DEFAULT '1',
	PRIMARY KEY (`ID`)
);

CREATE TABLE `Bill` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`Date_created` DATETIME NOT NULL,
	`Created_by` INT NOT NULL,
	`Customer_Phone` VARCHAR(10) NOT NULL,
	`Customer_Name` VARCHAR(255) NOT NULL,
	`Customer_address` VARCHAR(255),
    `total` INT ,
	PRIMARY KEY (`id`,`Created_by`)
);

CREATE TABLE `Bill_detail` (
	`Bill_id` INT NOT NULL,
	`Product_id` INT NOT NULL,
	`Quantity` INT NOT NULL,
	PRIMARY KEY (`Bill_id`,`Product_id`)
);

CREATE TABLE `Category` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`Name` VARCHAR(255) NOT NULL,
	`active` INT NOT NULL DEFAULT '1',
	`Description` VARCHAR(255) NOT NULL,
	PRIMARY KEY (`id`)
);

ALTER TABLE `User` ADD CONSTRAINT `User_fk0` FOREIGN KEY (`Role`) REFERENCES `role`(`ID`);

ALTER TABLE `authority_detail` ADD CONSTRAINT `authority_detail_fk0` FOREIGN KEY (`ID_role`) REFERENCES `role`(`ID`);

ALTER TABLE `authority_detail` ADD CONSTRAINT `authority_detail_fk1` FOREIGN KEY (`ID_authority`) REFERENCES `authority`(`ID`);

ALTER TABLE `Account` ADD CONSTRAINT `Account_fk0` FOREIGN KEY (`ID_user`) REFERENCES `User`(`ID`);

ALTER TABLE `Product` ADD CONSTRAINT `Product_fk0` FOREIGN KEY (`Brand`) REFERENCES `Brand`(`ID`);

ALTER TABLE `Product` ADD CONSTRAINT `Product_fk1` FOREIGN KEY (`Category`) REFERENCES `Category`(`id`);

ALTER TABLE `Product` ADD CONSTRAINT `Product_fk2` FOREIGN KEY (`Created_by`) REFERENCES `Account`(`ID`);

ALTER TABLE `Product` ADD CONSTRAINT `Product_fk3` FOREIGN KEY (`Edited_by`) REFERENCES `Account`(`ID`);

ALTER TABLE `Bill` ADD CONSTRAINT `Bill_fk0` FOREIGN KEY (`Created_by`) REFERENCES `Account`(`ID`);

ALTER TABLE `Bill_detail` ADD CONSTRAINT `Bill_detail_fk0` FOREIGN KEY (`Bill_id`) REFERENCES `Bill`(`id`);

ALTER TABLE `Bill_detail` ADD CONSTRAINT `Bill_detail_fk1` FOREIGN KEY (`Product_id`) REFERENCES `Product`(`ID`);



INSERT INTO role (ID,Name) VALUES (0,'admin');
Update role set id=0 where name='admin';
INSERT INTO user (ID, Name, Address, Phone, Email, Role, CCCD) VALUES (0, 'admin', '', '', '', 0, '');
Update user set id=0 where name='admin';
INSERT INTO `account` (`ID`, `ID_user`, `UserName`, `Password`,date_Created,date_edited,last_login) VALUES (0, 0, 'admin', 'admin','2023-11-27 17:01:40','2023-11-27 17:01:40','2023-11-27 17:01:40');
Update account set id=0 where Username='admin';
INSERT INTO role (ID,Name) VALUES (1,'staff');

DELIMITER //

CREATE TRIGGER update_product_quantity
AFTER INSERT ON bill_detail
FOR EACH ROW
BEGIN
    DECLARE new_quantity INT;

    -- Get the quantity from the product table
    SELECT quantity INTO new_quantity
    FROM product
    WHERE id = NEW.product_id;

    -- Subtract the quantity from the product table
    UPDATE product
    SET quantity = new_quantity - NEW.quantity
    WHERE id = NEW.product_id;
END;
INSERT INTO `authority` VALUES (1,'view product'),(2,'add product'),(3,'edit product'),(4,'view user'),(5,'add user'),(6,'edit user'),(7,'view brand'),(8,'add  brand'),(9,'edit brand'),(10,'view category'),(11,'add category'),(12,'edit category'),(13,'view role'),(14,'add role'),(15,'edit role'),(16,'view account'),(17,'add account'),(18,'edit account'),(19,'view bill'),(20,'create bill'),(21,'statistic'),(22,'adjust action');
//