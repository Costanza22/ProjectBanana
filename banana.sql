CREATE DATABASE IF NOT EXISTS bananeiras;

USE bananeiras;

CREATE TABLE IF NOT EXISTS especies (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    nome_cientifico VARCHAR(255) NOT NULL,
    descricao TEXT NOT NULL,
    origem VARCHAR(100) NOT NULL
);
INSERT INTO especies (nome, nome_cientifico, descricao, origem) VALUES
('Bananeira Comum', 'Musa acuminata', 'A bananeira comum é a espécie mais conhecida de banana, produzindo frutos amarelos e saborosos.', 'Sudeste da Ásia'),
('Bananeira Plantain', 'Musa paradisiaca', 'A bananeira plantain é conhecida por seus frutos verdes e mais amidosos, geralmente cozidos antes de serem consumidos.', 'Sudeste da Ásia'),
('Bananeira Prata', 'Musa balbisiana', 'A bananeira prata é famosa por seus frutos prateados e sabor adocicado.', 'Sul da China');
