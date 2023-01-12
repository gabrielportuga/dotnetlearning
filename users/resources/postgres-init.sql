CREATE DATABASE userdb;

\c userdb;

CREATE TABLE "user" (
    "id" INT NOT NULL,
    "name" VARCHAR(100) NOT NULL,
    "email" VARCHAR(100) NOT NULL,
    CONSTRAINT "pk_user" PRIMARY KEY ("id")
);
