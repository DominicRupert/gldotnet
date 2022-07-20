CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS cars(
        id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        make VARCHAR(255) NOT NULL,
        price INT NOT NULL,
        year INT NOT NULL,
        description VARCHAR(255) NOT NULL,
        image VARCHAR(255) NOT NULL

        

    ) default charset utf8;
CREATE TABLE
    IF NOT EXISTS houses(
        id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
        name VARCHAR(255) NOT NULL
        
    ) default charset utf8;

  



    INSERT INTO cars(make, price, year, description, image )
    VALUES
    ("ford", 2000, 1994, "car", "https://thiscatdoesnotexist.com"  );


    SELECT * FROM cars;
    SELECT * FROM cars WHERE id = 1;

DROP TABLE cars;


    