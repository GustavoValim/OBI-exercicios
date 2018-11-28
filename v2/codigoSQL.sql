CREATE DATABASE sistemaBancoLP;

USE  sistemaBancoLP;


CREATE TABLE Maquiagem(

	id INTEGER primary key auto_increment,
	codigo VARCHAR(20) NOT NULL,	
    nome VARCHAR(20) NOT NULL,    
    preco DECIMAL NOT NULL,     
    descricao VARCHAR(200) NOT NULL,    
    quantidade INTEGER NOT NULL,
    pontos INTEGER NOT NULL,    
    quantidadeMinima INTEGER NOT NULL,

	peso FLOAT,
    cor VARCHAR(20)
);

CREATE TABLE Perfume(

	id INTEGER primary key auto_increment,
	codigo VARCHAR(20) NOT NULL,	
    nome VARCHAR(20) NOT NULL,    
    preco DECIMAL NOT NULL,     
    descricao VARCHAR(200) NOT NULL,    
    quantidade INTEGER NOT NULL,
    pontos INTEGER NOT NULL,    
    quantidadeMinima INTEGER NOT NULL,

	ml FLOAT,
	marca VARCHAR(20)
);

CREATE TABLE Cozinha(

	id INTEGER primary key auto_increment,
	codigo VARCHAR(20) NOT NULL,	
    nome VARCHAR(20) NOT NULL,    
    preco DECIMAL NOT NULL,     
    descricao VARCHAR(200) NOT NULL,    
    quantidade INTEGER NOT NULL,
    pontos INTEGER NOT NULL,    
    quantidadeMinima INTEGER NOT NULL,

	peso FLOAT,
    altura FLOAT,
    largura FLOAT,
    material VARCHAR(20)
);

CREATE TABLE Quarto(

	id INTEGER primary key auto_increment,
	codigo VARCHAR(20) NOT NULL,	
    nome VARCHAR(20) NOT NULL,    
    preco DECIMAL NOT NULL,     
    descricao VARCHAR(200) NOT NULL,    
    quantidade INTEGER NOT NULL,
    pontos INTEGER NOT NULL,    
    quantidadeMinima INTEGER NOT NULL,	
    
	cor VARCHAR(20),
    altura FLOAT,
	largura FLOAT,
    material FLOAT
    
);

CREATE TABLE Roupa(

	id INTEGER primary key auto_increment,
	codigo VARCHAR(20) NOT NULL,	
    nome VARCHAR(20) NOT NULL,    
    preco DECIMAL NOT NULL,     
    descricao VARCHAR(200) NOT NULL,    
    quantidade INTEGER NOT NULL,
    pontos INTEGER NOT NULL,    
    quantidadeMinima INTEGER NOT NULL,

	cor VARCHAR(20),
    tamanho VARCHAR(3)
);



CREATE TABLE Cliente(
	codigo INTEGER PRIMARY KEY auto_increment,
	nome VARCHAR(50),
    nomeRua VARCHAR(50),
    nroRua VARCHAR(50),
    bairro VARCHAR(50),
    telefone VARCHAR(50),
	complemento VARCHAR(50),
    estado VARCHAR(3) default 'não'
);

CREATE TABLE tpProduto(
	id INTEGER PRIMARY KEY auto_increment NOT NULL,
    descricao VARCHAR(20) NOT NULL
);



 CREATE TABLE Estoque ( 
		idProduto INTEGER NOT NULL, 
        tipo INTEGER NOT NULL, 
        quantidadeProduto INTEGER NOT NULL,
        quantidadeMinima INTEGER NOT NULL,        
        CONSTRAINT fk_tipoProduto FOREIGN KEY (idProduto) REFERENCES tpProduto(id)  
);
