create database bibliotech;

use bibliotech;


create table usuarios (
id int auto_increment,
nome varchar(40) not null,
email varchar(60) not null,
senha varchar(32) not null,
data_nascimento datetime not null,
status bit(1) default 1,
primary key(id)
);


create table penalidades(
id_usuario int auto_increment,
tipo enum('banido', 'suspenso'),
foreign key(id_usuario) references usuarios(id)
);

create table enderecos(	
id int auto_increment,
id_usuario int, 
cep varchar(8),
logradouro varchar(75), 
numero varchar(6),
complemento varchar(20),
bairro varchar(25),
cidade varchar(25),
uf char(2),
tipo varchar(30),
primary key(id),
foreign key(id_usuario) references usuarios(id)
);

create table log_usuarios(
id int auto_increment,
id_usuario int,
periodo datetime default current_timestamp,
atividade bit(1) default 1, 
primary key(id),
foreign key(id_usuario) references usuarios(id)
);

create table estoque(
id_livro int,
quantidade int,
disponiveis int,
foreign key(id_livro) references livros(id)
);

create table controle_estoque(
id_livro int,
movimento enum('entrada', 'saida', 'perda'), 
quantidade int, 
data_mov datetime default current_timestamp,
foreign key(id_livro) references livros(id)
);

create table livros(
id int auto_increment,
nome varchar(120),
id_autor int,
id_editora int,
descricao text,
dimensao varchar(7),
id_genero int,
data_pub datetime,
imagem blob,
primary key(id),
foreign key(id_autor) references autores(id),
foreign key(id_editora) references editoras(id),
foreign key(id_genero) references generos(id)
);

create table avaliacao_livro(
id_livro int, 
nivel tinyint(5),
foreign key(id_livro) references livros(id)
);

create table reservas(
id int auto_increment,
id_usuario int, 
id_livro int,
data_reserva datetime default current_timestamp,
data_devolucao datetime,
status enum('aberto', 'finalizado'),
primary key(id),
foreign key(id_usuario) references usuarios(id),
foreign key(id_livro) references usuarios(id)
);

delimiter $$
create trigger tr_atualizar_estoque
after insert on controle_estoque
for each row
begin
	if new.movimento = 'entrada' then
		update estoque
        set quantidade = quantidade + new.quantidade,
        disponiveis = disponiveis + new.quantidade
        where id_livro = new.id_livro;
        
	elseif new.movimento = 'saida' then
		update estoque 
        set disponiveis = disponiveis - new.quantidade
        where id_livro = new.id_livro;
        
	elseif new.movimento = 'perda' then 
		update estoque
        set quantidade = quantidade - new.quantidade,
        disponiveis = disponiveis = new.quantidade
        where id_livro = new.id_livro;
        
	end if;
end$$