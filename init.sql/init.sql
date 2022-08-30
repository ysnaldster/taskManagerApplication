CREATE TABLE Category(
    ID uuid PRIMARY KEY NOT NULL,
    name VARCHAR(60) NOT NULL,
    description ntext
);

CREATE TABLE Task(
    ID uuid PRIMARY KEY not null,
    category_id_fk uuid,
    title  varchar(200),
    description ntext,
    priority int,
    creation_date TIMESTAMP,
    CONSTRAINT category_id_fk
    FOREIGN KEY (category_id_fk) REFERENCES Category (ID)
);