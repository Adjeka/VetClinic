create procedure spContractLocations_Update(
	p_id int, 
	p_id_location int, 
	p_id_contract int, 
	p_examination_cost int
)
as $$ 
begin 
	update ContractLocations
	set id_location =  p_id_location, id_contract = p_id_contract, examination_cost = p_examination_cost
	where id = p_id;
end; 
$$ language plpgsql; 