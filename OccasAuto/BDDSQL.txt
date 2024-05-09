DROP DATABASE IF EXISTS bdoccasauto;
CREATE DATABASE IF NOT EXISTS bdoccasauto;
USE bdoccasauto;


DROP TABLE IF EXISTS Concessionnaire;
CREATE TABLE IF NOT EXISTS Concessionnaire
 id INT(3) auto_increment,
    nom VARCHAR(15),
    prenom VARCHAR(15),
    adresse VARCHAR(30),
    cp INT(5),
    ville VARCHAR(20),
    PRIMARY KEY (id)
)Engine = innoDB;


DROP TABLE IF EXISTS Utilisateur;
CREATE TABLE IF NOT EXISTS utilisateur(
    identifiant int(10) auto_increment,
    login Varchar(30),
    mdp Varchar(300) NOT NULL,
    Primary KEY (identifiant, login)
)Engine=InnoDB;

INSERT INTO Utilisateur (login, mdp) VALUES ('admin', '21232f297a57a5a743894a0e4a801fc3');

INSERT INTO Concessionnaire (nom,prenom,adresse,cp,ville) VALUES 
('Davolio', 'Jeanne', '5 rue de la poste', '63000', 'CLERMONT-FERRAND'),
('Fuller', 'Philippe', '254 avenue Berthelot', '63000', 'CLERMONT-FERRAND'),
('Daverling', 'Laura', '1 place de Jaude', '63000', 'CLERMONT-FERRAND'),
('Peacock', 'Emilie', '23, Impasse des Fleurs', '63000', 'CLERMONT-FERRAND'),
('Buchanan', 'Pierre', '32 place de l''Hôtel de Ville', '63200', 'RIOM'),
('Bucyama', 'Michel', '15 rue des pinsons', '63200', 'RIOM'),
('King', 'Louis', '57 rue de la gare', '63500', 'ISSOIRE'),
('Callahan', 'Jean', '23 boulevard Central', '63500', 'ISSOIRE'),
('Bucsworth', 'Pierre', '7 rue de la paix', '63500', 'ISSOIRE');
