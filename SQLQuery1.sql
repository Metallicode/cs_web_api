CREATE DATABASE metaldatabase;

USE metaldatabase;

CREATE TABLE USERS_POSTS(
   ID			  INT			PRIMARY KEY     NOT NULL,
   First_Name     VARCHAR(50)					NOT NULL,
   Last_Name      VARCHAR(50)					NOT NULL,
   Email	      VARCHAR(50),
   Text			  VARCHAR(250)
);


INSERT INTO USERS_POSTS (ID, First_Name, Last_Name, Email, Text)
VALUES (1,'bob','john','bobjohn@metallicode.com','hi this is bob');
INSERT INTO USERS_POSTS (ID, First_Name, Last_Name, Email, Text)
VALUES (2,'nona','roberto','roberto@metallicode.com','yo yo yo!');
INSERT INTO USERS_POSTS (ID, First_Name, Last_Name, Email, Text)
VALUES (3,'aphex','metal','aphex@metallicode.com','aphex twin is ok');
INSERT INTO USERS_POSTS (ID, First_Name, Last_Name, Email, Text)
VALUES (4,'sad','bill','sad@hate.com','i hate bob');
INSERT INTO USERS_POSTS (ID, First_Name, Last_Name, Email, Text)
VALUES (5,'mary','kol','m_kol@yahoo.com','i eat fish');
INSERT INTO USERS_POSTS (ID, First_Name, Last_Name, Email, Text)
VALUES (6,'button','josef','bbb@sef.com','this is so fail...');
INSERT INTO USERS_POSTS (ID, First_Name, Last_Name, Email, Text)
VALUES (7,'ok','stop','no_more@metallicode.com','please');
INSERT INTO USERS_POSTS (ID, First_Name, Last_Name, Email, Text)
VALUES (8,'bob','bob','bob@bobcode.com','hi this is bobbob');






DELETE FROM USERS_POSTS;
