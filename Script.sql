-- CRIANDO O BANCO DE DADOS
CREATE DATABASE BDProjeto;

-- USANDO BANCO DE DADOS
USE BDProjeto;

-- CRIANDO AS TABELAS DO BANCO DE DADOS
CREATE TABLE tbLogin(
codLogin int primary key auto_increment,
 usuario varchar (40),
 senha varchar (40)
 );

-- CONSULTANDO AS TABELAS
SELECT*FROM tbLogin;