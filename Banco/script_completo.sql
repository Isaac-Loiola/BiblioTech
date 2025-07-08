create database bibliotech;

use bibliotech;


create table usuarios (
id int auto_increment,
nome varchar(50) not null,
email varchar(70) not null,
senha varchar(32) not null,
data_nascimento datetime not null,
status bit(1) default 1,
primary key(id)
);

create table penalidades(
id int auto_increment,
id_usuario int ,
tipo enum('banido', 'suspenso'),
status enum('fechada', 'aberta') default 'aberta',
data_inicio datetime default current_timestamp,
data_fim datetime,
primary key(id),
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
id int auto_increment,
id_livro int,
movimento enum('entrada', 'saida', 'perda'), 
quantidade int, 
data_mov datetime default current_timestamp,
primary key(id),
foreign key(id_livro) references livros(id)
);

create table autores(
id int auto_increment,
nome varchar(50),
data_nascimento datetime,
pais varchar(30),
cidade_nascimento varchar(85),
primary key(id)
);

create table editoras(
id int auto_increment,
nome varchar(50),
pais varchar(30),
data_criacao datetime,
primary key(id)
);

create table generos(
	id int auto_increment,
    genero varchar(30),
    primary key(id)
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

delimiter $$
create procedure sp_usuarios_insert(
	spnome varchar(50),
    spemail varchar(70),
    spsenha varchar(32),
    spdata_nascimento datetime
)
begin
	insert usuarios
    values(0, spnome, spemail, spsenha, spdata_nascimento, default);
    select last_insert_id();
end$$


delimiter $$
create procedure sp_usuarios_status(
	spid int,
	spstatus bit(1)
)
begin
	update usuarios
    set status = spstatus
    where id = spid;
end$$


delimiter $$
create procedure sp_usuarios_update(
	spid int,
    spsenha varchar(32)
)
begin
	update usuarios
    set senha = spsenha
    where id = spid;
end$$

delimiter $$
create procedure sp_penalidades_insert(
	spid_usuario int,
    sptipo enum('banido', 'suspenso')
)
begin
	insert penalidades(id_usuario, tipo, status, data_inicio)
	values(spid_usuario, sptipo, default, default);
    select last_insert_id();
end$$


delimiter $$
create procedure sp_penalidades_update(
	spid int,
    spstatus enum('fechada', 'aberta'),
    spdata_fim datetime
)
begin
	update penalidades
    set status = 'fechada',
    data_fim = current_timestamp
    where id = spid;
end$$

delimiter $$
create procedure sp_log_usuario_insert(
    spid_usuario int,
	spatividade bit(1)
)
begin
	insert log_usuarios
    values(0, spid_usuario, default, spatividade);
end$$

delimiter $$
create procedure sp_reservas_insert(
    spid_usuario int,
	spid_livro int,
    spdata_devolucao datetime
)
begin
	insert reservas
    values(0, spid_usuario, spid_livro, default, spdata_devolucao, default);
end$$

delimiter $$
create procedure sp_reservas_finalizar(
	spid int
)
begin
	update reservas
    set status = 'finalizado'
    where id = spid;
end$$

delimiter $$
create procedure sp_livros_insert(
    spnome varchar(120),
    spid_autor int,
    spid_editora int,
    spdescricao text,
    spdimensao varchar(7),
    spid_genero int,
    spdata_pub datetime,
    spimagem blob
)
begin
	insert livros
    values(0, spnome, spid_autos, spid_editora, spdescricao, spdimensao, spid_genero, spdata_pub, spimagem);
    select last_insert_id();
end$$

delimiter $$
create procedure sp_enderecos_insert(
	spid_usuario int, 
	spcep varchar(8),
	splogradouro varchar(75), 
	spnumero varchar(6),
	spcomplemento varchar(20),
	spbairro varchar(25),
	spcidade varchar(25),
	spuf char(2),
	sptipo varchar(30)
)
begin 
	insert enderecos
    values(0, spid_usuario, spcep, splogradouro, spnumero, spcomplemento, spbairro, spcidade, spuf, sptipo);
    select last_insert_id();
end $$

delimiter $$
create procedure sp_controle_estoque_insert(
    spid_livro int,
    spmovimento enum('entrada', 'saida', 'perda'),
    spquantidade int
)
begin
	insert controle_estoque
    values(0, spid_livro, spmovimento, spquantidade, default);
end$$

delimiter $$
create procedure sp_avaliacao_livro(
	spid_livro int,
    spnivel tinyint(5)
)
begin
	insert avaliacao_livro 
    values(spid_livro, spnivel);
end $$

delimiter $$
create procedure sp_autores_insert(
	spnome varchar(50),
	spdata_nascimento datetime,
	sppais varchar(30),
	spcidade_nascimento varchar(85)
)
begin
	insert autores
    values(0, spnome, spdata_nascimento, sppais, spcidade_nascimento);
    select last_insert_id();
end$$

delimiter $$
create procedure sp_editoras_insert(
	spnome varchar(50),
	sppais varchar(30),
	spdata_criacao datetime
)
begin
	insert editoras
    values(0, spnome, sppais, spdata_criacao);
    select last_insert_id();
end$$

delimiter $$
create procedure sp_generos_insert(
	spgenero varchar(30)
)
begin
	insert generos
    values(0, spgenro);
    select last_insert_id();
end$$