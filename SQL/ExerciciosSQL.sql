/*2.1 */
select * from tabela_pessoa;
select evento from tabela_evento where tabela_pessoas.id like tabela_evento.pessoa_id;

/*2.2 */
select * from tabela_pessoa 
where nome like '%Doe';

/*2.3 */
insert INTO tabela_evento (id,evento,pessoa_id)
values (default,"Evento E", 5); 

/*2.4 */
update tabela_eventos set pessoa_id = 1 where pessoa_id = NULL;

/*2.5 */
delete from tabela_eventos where evento = 'Evento B'; 

/*2.6 */
delete from tabela_pessoas
where id not in (select pessoa_id from tabela_eventos);

/*2.7 */
alter table tabela_pessoa
add idade integer;

/*2.8 */
create table tabela_telefone (

	id integer AUTO_INCREMENT,
	telefone varchar(200),
    pessoa_id integer,
    primary key(id),
    foreign key(pessoa_id) references tabela_pessoa(id)
);

/*2.9 */
alter table tabela_telefone 
add unique(telefone);

/*2.10 */
drop table tabela_telefone;

