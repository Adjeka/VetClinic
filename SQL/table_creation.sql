CREATE TABLE Locations
(
	id SERIAL PRIMARY KEY,
	name VARCHAR(50) NOT NULL,
	examination_cost MONEY NOT NULL
);

CREATE TABLE AnimalCategories
(
	id SERIAL PRIMARY KEY, 
	name VARCHAR(20) NOT NULL
);


CREATE TABLE Animals
(
	id SERIAL PRIMARY KEY, 
	registration_number INT NOT NULL, 
	id_location INT NOT NULL, 
	id_category INT NOT NULL, 
	sex VARCHAR(1) NOT NULL,
	birth_year INT NOT NULL, 
	chip_number INT NOT NULL, 
	nickname VARCHAR(100) NOT NULL, 
	distinguishing_marks TEXT,
	FOREIGN KEY (id_location) REFERENCES Location(id) ON DELETE CASCADE,
	FOREIGN KEY (id_category) REFERENCES AnimalCategory(id) ON DELETE CASCADE,
	UNIQUE(registration_number, chip_number)
);


CREATE TABLE AnimalPhotos 
(
	id SERIAL PRIMARY KEY, 
	id_animal INT NOT NULL, 
	file_path VARCHAR(500) NOT NULL,
	FOREIGN KEY (id_animal) REFERENCES Animal(id) ON DELETE CASCADE
);


CREATE TABLE OwnerSigns 
(
	id SERIAL PRIMARY KEY, 
	name VARCHAR(50) NOT NULL
);


CREATE TABLE AnimalOwnerSigns
(
	id SERIAL PRIMARY KEY, 
	id_animal INT NOT NULL, 
	id_owner_sign INT NOT NULL,
	FOREIGN KEY (id_animal) REFERENCES Animal(id) ON DELETE CASCADE,
	FOREIGN KEY (id_owner_sign) REFERENCES OwnerSigns(id) ON DELETE CASCADE
);


CREATE TABLE OrganizationTypes
(
	id SERIAL PRIMARY KEY,
	name VARCHAR(100) NOT NULL,
	UNIQUE(name)
);


CREATE TABLE OrganizationAttributes
(
	id SERIAL PRIMARY KEY,
	name VARCHAR(30) NOT NULL, 
	UNIQUE(name)
);


CREATE TABLE Organizations 
(
	id SERIAL PRIMARY KEY,
	name VARCHAR(100) NOT NULL,
	INN NUMERIC(12) NOT NULL,
	KPP NUMERIC(9) NOT NULL,
	city VARCHAR(40) NOT NULL,
	street VARCHAR(50) NOT NULL,
	house_number INT NOT NULL,
	id_organization_type INT,
	id_organization_attribute INT,
	id_location INT,
	FOREIGN KEY (id_organization_type) REFERENCES Organization_type (id) ON DELETE SET NULL,
	FOREIGN KEY (id_organization_attribute) REFERENCES Organization_attribute (id) ON DELETE SET NULL,
	FOREIGN KEY (id_location) REFERENCES Location (id) ON DELETE SET NULL,
	UNIQUE(INN, KPP)
);

CREATE TABLE Contracts
(
	id SERIAL PRIMARY KEY, 
	number INT NOT NULL,
	signing_date DATE NOT NULL DEFAULT NOW(),
	valid_until DATE NOT NULL,
	id_client INT,
	id_executor INT,
	FOREIGN KEY (id_client) REFERENCES Organization (id) ON DELETE SET NULL,
	FOREIGN KEY (id_executor) REFERENCES Organization (id) ON DELETE SET NULL,
	UNIQUE(number)
);

CREATE TABLE MedicalExaminations 
(
	id SERIAL PRIMARY KEY, 
	id_animal INT, 
	behaviour_features VARCHAR(200), 
	animal_condition VARCHAR(200) NOT NULL, 
	body_temperature REAL NOT NULL, 
	skin_covers VARCHAR(200) NOT NULL, 
	wool_condition VARCHAR(200) NOT NULL, 
	injuries VARCHAR(200), 
	emergency_help_required BIT NOT NULL, 
	diagnosis VARCHAR(200) NOT NULL, 
	actions_taken VARCHAR(300), 
	treatment_prescribed VARCHAR(300) NOT NULL, 
	examination_date DATE DEFAULT NOW(), 
	veterinarian_full_name VARCHAR(200) NOT NULL, 
	veterinarian_position VARCHAR(50) NOT NULL, 
	id_vet_clinic INT NOT NULL, 
	id_municipal_contract INT NOT NULL, 
	FOREIGN KEY (id_animal) REFERENCES Animal(id) ON DELETE CASCADE,
	FOREIGN KEY (id_vet_clinic) REFERENCES Organization(id) ON DELETE CASCADE,
	FOREIGN KEY (id_municipal_contract) REFERENCES Contract(id) ON DELETE CASCADE
);

CREATE TABLE ContractLocations 
(
	id SERIAL PRIMARY KEY, 
	id_location INT NOT NULL,
	id_contract INT NOT NULL,
	FOREIGN KEY (id_location) REFERENCES Location (id) ON DELETE CASCADE,
	FOREIGN KEY (id_contract) REFERENCES Contract (id) ON DELETE CASCADE
);


CREATE TABLE PermissionManagers (
	id SERIAL PRIMARY KEY,
	name VARCHAR(50) NOT NULL, 
	UNIQUE(name)
);


CREATE TABLE UserRoles (
	id SERIAL PRIMARY KEY,
	name VARCHAR(50), 
	UNIQUE(name)
);

CREATE TABLE Users
(
	id SERIAL PRIMARY KEY,
	name VARCHAR(100) NOT NULL,
	surname VARCHAR(100) NOT NULL,
	patronymic VARCHAR(100),
	login VARCHAR(100) NOT NULL,
	password VARCHAR(100) NOT NULL,
	id_role INT NOT NULL,
	id_permission_manager INT NOT NULL,
	id_workplace INT,
	FOREIGN KEY (id_role) REFERENCES UserRoles (id) ON DELETE CASCADE,
	FOREIGN KEY (id_permission_manger) REFERENCES PermissionManagers (id)  ON DELETE CASCADE, 
	FOREIGN KEY (id_workplace) REFERENCES Organization (id)  ON DELETE SET NULL,
	UNIQUE(login)
);