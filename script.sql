CREATE TABLE service(
   idservice INT AUTO_INCREMENT,
   nom VARCHAR(50) ,
   PRIMARY KEY(idservice)
);

CREATE TABLE motif(
   idmotif INT AUTO_INCREMENT,
   libelle VARCHAR(128) ,
   PRIMARY KEY(idmotif)
);

CREATE TABLE personnel(
   idpersonnel INT AUTO_INCREMENT,
   nom VARCHAR(50) ,
   prenom VARCHAR(50) ,
   tel VARCHAR(15) ,
   mail VARCHAR(128) ,
   idservice INT NOT NULL,
   PRIMARY KEY(idpersonnel),
   FOREIGN KEY(idservice) REFERENCES service(idservice)
);

CREATE TABLE absence(
   idpersonnel INT,
   datedebut DATETIME,
   datefin DATETIME,
   idmotif INT NOT NULL,
   PRIMARY KEY(idpersonnel, datedebut),
   FOREIGN KEY(idpersonnel) REFERENCES personnel(idpersonnel),
   FOREIGN KEY(idmotif) REFERENCES motif(idmotif)
);

CREATE TABLE responsable(
   login VARCHAR(64),
   pwd VARCHAR(128)
);

CREATE USER 'mediatek'@'%' IDENTIFIED BY 'motdepasseuser';

GRANT ALL PRIVILEGES ON mediatek86.* TO 'mediatek'@'%';

INSERT INTO responsable (login, pwd) VALUES ("mediatek", SHA2("RespMediaTek86", 256));

INSERT INTO motif (libelle) VALUES ("vacances"), ("maladie"), ("motif familial"), ("congé parental");

INSERT INTO service (nom) VALUES ("administratif"), ("médiation culturelle"), ("prêt");

INSERT INTO personnel (nom, prenom, tel, mail, idservice)
VALUES
  ("Dyer","Cherokee","05 52 24 24 99","in.tempus.eu@aol.ca",2),
  ("Rowe","Jillian","07 61 03 87 27","lectus.sit@protonmail.org",1),
  ("Roy","Victor","04 15 78 48 65","ultrices.a@google.net",3),
  ("Frost","Darius","07 25 60 09 18","enim.curabitur.massa@yahoo.couk",2),
  ("Dorsey","Baker","04 32 44 50 60","massa@hotmail.couk",2),
  ("Jordan","Herman","05 28 54 43 58","augue.ut.lacus@hotmail.ca",2),
  ("Justice","Raymond","02 73 52 58 33","amet.dapibus@yahoo.edu",1),
  ("Dorsey","Vance","02 98 63 17 26","cras.sed.leo@yahoo.net",3),
  ("Wooten","Sylvia","04 75 21 35 85","mus.donec.dignissim@yahoo.couk",3),
  ("Hutchinson","Magee","03 87 73 18 41","phasellus.ornare@aol.org",2);
  
INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif)
VALUES
  (4,"2024-04-10 02:53:52","2024-04-12 13:17:52",4),
  (10,"2024-02-27 02:52:03","2024-02-28 03:16:09",4),
  (5,"2024-12-02 06:43:42","2024-12-05 11:20:16",2),
  (2,"2024-02-16 21:19:49","2024-02-21 09:04:12",3),
  (7,"2024-03-23 09:08:11","2024-04-02 13:10:00",2),
  (3,"2024-08-15 19:12:14","2024-08-18 01:38:15",3),
  (5,"2024-09-28 05:20:28","2024-09-30 10:03:12",4),
  (9,"2024-05-03 03:45:02","2024-05-27 11:10:07",2),
  (5,"2025-01-13 16:44:15","2025-02-03 09:30:40",3),
  (7,"2024-03-07 05:24:35","2024-03-14 04:53:54",3),
  (6,"2024-12-16 13:28:17","2024-12-19 06:56:57",2),
  (8,"2024-09-17 16:44:31","2024-10-01 19:28:18",1),
  (9,"2024-08-04 16:40:32","2024-08-29 11:44:17",1),
  (2,"2024-02-10 04:28:25","2024-02-14 05:31:11",3),
  (7,"2024-10-04 03:59:23","2024-10-06 14:24:56",3),
  (5,"2024-12-20 10:39:40","2024-12-21 05:46:51",1),
  (3,"2024-10-25 17:59:48","2024-10-26 21:08:17",2),
  (1,"2024-12-20 21:52:31","2024-12-23 21:15:57",2),
  (1,"2024-12-22 19:56:38","2024-12-30 06:22:52",1),
  (8,"2024-03-13 06:17:26","2024-03-15 04:07:26",1),
  (4,"2024-06-07 03:42:00","2024-06-09 10:37:22",4),
  (4,"2024-11-03 10:47:43","2024-11-08 23:10:54",1),
  (3,"2024-09-21 01:31:42","2024-09-28 05:39:27",3),
  (10,"2025-04-10 08:37:22","2025-05-05 10:15:46",3),
  (2,"2025-01-27 21:04:16","2025-01-28 11:13:09",4),
  (1,"2024-05-05 13:07:08","2024-05-18 11:41:32",1),
  (3,"2024-11-15 09:02:47","2024-11-17 14:43:06",2),
  (3,"2024-02-15 04:06:33","2024-03-01 01:42:57",2),
  (3,"2024-05-31 19:36:49","2024-06-04 20:04:47",3),
  (6,"2024-07-04 06:05:28","2024-07-26 04:33:11",2),
  (7,"2024-07-10 03:23:59","2024-07-31 03:39:33",1),
  (4,"2024-09-05 18:57:01","2024-09-14 23:30:28",2),
  (3,"2024-09-23 08:36:52","2024-09-25 07:15:28",2),
  (1,"2024-01-19 13:43:49","2024-01-26 00:23:52",2),
  (2,"2025-02-10 13:40:19","2025-02-25 23:33:33",1),
  (4,"2024-05-18 07:29:02","2024-05-19 03:50:07",2),
  (5,"2025-03-26 07:21:47","2025-03-27 06:52:33",4),
  (2,"2025-03-30 17:44:31","2025-04-06 08:12:33",1),
  (5,"2025-03-31 14:53:52","2025-04-02 12:26:26",3),
  (7,"2024-01-21 04:15:40","2024-01-25 12:04:06",1),
  (7,"2024-01-03 07:18:55","2024-01-23 21:26:38",3),
  (6,"2024-09-09 01:33:31","2024-09-10 03:31:41",2),
  (1,"2025-03-11 00:07:00","2025-03-26 08:15:23",3),
  (8,"2024-07-11 11:31:09","2024-07-30 09:45:02",3),
  (5,"2025-01-20 12:42:14","2025-01-26 12:39:08",2),
  (5,"2024-04-17 11:12:09","2024-04-19 09:46:10",4),
  (7,"2024-04-06 00:27:44","2024-04-29 06:31:00",3),
  (4,"2024-08-26 03:03:18","2024-09-06 19:45:59",1),
  (4,"2024-07-21 14:30:44","2024-07-22 06:54:07",4),
  (6,"2025-01-04 04:49:55","2025-02-11 13:22:05",3);