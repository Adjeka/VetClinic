create procedure spContractLocations_Delete(
	p_id int
)
as $$ 
begin 
	delete from ContractLocations
	where id = p_id;
end; 
$$ language plpgsql; 