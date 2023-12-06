create procedure spContracts_Update(
	p_id int, 
	p_number int, 
	p_signing_date date, 
	p_valid_until date,
	p_id_client int, 
	p_id_executor int 
)
as $$ 
begin 
	update Contracts
	set 
	number = p_number, signing_date = p_signing_date, valid_until = p_valid_until, id_client = p_id_client, id_executor = p_id_executor
	where id = p_id;
end; 
$$ language plpgsql; 