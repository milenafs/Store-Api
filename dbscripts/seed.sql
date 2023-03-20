--\connect storedb

CREATE TABLE store
(
    idGuid UNIQUEIDENTIFIER PRIMARY KEY default NEWID(),
    title  VARCHAR (100)  NOT NULL,
);

--ALTER TABLE "blog" OWNER TO storeuser;

Insert into store(title,description) values( default,'Bom Dia Mercado');
Insert into store(title,description) values( default,'Boa Tarde Mercado');
Insert into store(title,description) values( default,'Boa Noite Mercado');
Insert into store(title,description) values( default,'Mercado de MangaDB');
