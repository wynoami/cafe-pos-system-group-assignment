DROP USER IF EXISTS 'cs_dev'@'localhost';
CREATE USER 'cs_dev'@'localhost' IDENTIFIED BY 'MY$4L-310W$' ;
GRANT ALL PRIVILEGES ON FourthWallCafe.* TO 'cs_dev'@'localhost';
FLUSH PRIVILEGES;
