DROP USER IF EXISTS 'cs_dev'@'localhost';
CREATE USER 'cs_dev'@'localhost' IDENTIFIED BY '73$7D41V3' ;
GRANT ALL PRIVILEGES ON FourthWallCafe.* TO 'cs_dev'@'localhost';
FLUSH PRIVILEGES;
