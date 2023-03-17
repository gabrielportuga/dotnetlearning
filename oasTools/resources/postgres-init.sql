CREATE DATABASE dealerdb;

\c dealerdb;

CREATE TABLE "dealer" (
    "id" INT NOT NULL,
    "name" VARCHAR(100) NOT NULL,
    "email" VARCHAR(100) NOT NULL,
    CONSTRAINT "pk_dealer" PRIMARY KEY ("id")
);
