USE master
IF EXISTS(select * from sys.databases where name='MoviesDb')
DROP DATABASE [MoviesDb]

CREATE DATABASE [MoviesDb]