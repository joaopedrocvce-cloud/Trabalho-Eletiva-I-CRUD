--drop database Lancamento_Eletiva
create database Lancamento_Eletiva
go
use Lancamento_Eletiva
go

create login usuario with password='senha';
create user usuario from login usuario;
exec sp_addrolemember 'DB_DATAREADER', 'usuario';
exec sp_addrolemember 'DB_DATAWRITER', 'usuario';

create table lancamentos(
idLancamento INT not null IDENTITY(1,1) PRIMARY KEY,
descricaoLancamento VARCHAR(100) not null,
valorLancamento MONEY not null,
dataLancamento DATE not null,
tipoLancamento VARCHAR(7) not null CHECK (tipoLancamento in ('Entrada', 'Saída'))
)