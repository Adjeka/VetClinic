create procedure spContracts_Insert(
	inout p_id int, 
	p_number int, 
	p_signing_date date, 
	p_valid_until date,
	p_id_client int, 
	p_id_executor int 
)
as $$ 
begin 
	insert into Contracts (number, signing_date, valid_until, id_client, id_executor)
	values (p_number, p_signing_date, p_valid_until, p_id_client, p_id_executor)
	returning id into p_id;
end; 
$$ language plpgsql; 