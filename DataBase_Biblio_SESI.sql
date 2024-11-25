CREATE DATABASE Biblio_Sesi;
Use Biblio_Sesi;

CREATE TABLE Table_Cargo (
	CD_Cargo int primary key auto_increment not null,
    Cargo Varchar(45)
);


CREATE TABLE Table_Ano_Escolar (
	CD_Ano_Escolar int primary key auto_increment not null,
    Ano_Escolar varchar(45) -- 1° EF, 2° EF, 3° EF, 4° EF, 5° EF, 6° EF, 7° EF, 8° EF, 9° EF, 1° EM, 2° EM, 3° EM, Diretoria
);

CREATE TABLE Table_Unidade(
	CD_Unidade int primary key auto_increment not null,
    Nome_Unidade Varchar(45),
    Local_Unidade Varchar(45),
    IMG_Unidade Varchar(45),
    Descricao_Retirada Varchar(125)
);

CREATE TABLE Table_Livro (
	Order_Livro int primary key auto_increment,
	CD_Livro varchar(80) not null,
    Nome_Livro Varchar(80),
    Autor_Livro Varchar(80),
    QTD_estoque int,
    Numb_Paginas int,
    Edicao_Livro int,
    IMG_Livro Varchar(100),
    Descricao_Livro Varchar(2000),
    CFK_Unidade int,
    CONSTRAINT FK_Unidade FOREIGN KEY (CFK_Unidade) REFERENCES Table_Unidade(CD_Unidade)
);

CREATE TABLE Table_User (
	CD_User int primary key auto_increment,
	ID_Aluno Varchar(45) not null,
    NameUser Varchar(45),
    Nome_Completo Varchar(45),
    Senha Varchar(45),	
    IMG_User Varchar(45),
    CFK_Ano int,
	CFK_Cargo int,
    CFK_Unidade int,
    CONSTRAINT FK_Ano FOREIGN KEY (CFK_Ano) REFERENCES Table_Ano_Escolar(CD_Ano_Escolar),
    CONSTRAINT FK_Cargo FOREIGN KEY (CFK_Cargo) REFERENCES Table_Cargo(CD_Cargo),
    CONSTRAINT FK_Unit FOREIGN KEY (CFK_Unidade) REFERENCES Table_Unidade(CD_Unidade)
    ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE Table_Adm (
	CD_Adm int primary key not null auto_increment,
    NameUser_Adm Varchar(45),
    Senha_Adm Varchar(45),
    CFK_User int,
    constraint FK_usered foreign key (CFK_User) references Table_User(CD_User)
);

CREATE TABLE Table_Historico (
	CD_Hist int primary key auto_increment not null,
    DT_reserva datetime,
    DT_devolucao datetime,
    CFK_Livro int,
    CFK_User int,
    CONSTRAINT FK_Livro FOREIGN KEY (CFK_Livro) REFERENCES Table_Livro(Order_Livro),
    CONSTRAINT FK_User FOREIGN KEY (CFK_User) REFERENCES Table_User(CD_User)
);

CREATE TABLE Table_reservas(
    CD_Reservas int primary key auto_increment not null,
    DT_reserva datetime,
    DT_previsao_devolucao datetime,
    CFK_User int,
    CFK_Livro int,
    CONSTRAINT FK_Users foreign key (CFK_User) references Table_User(CD_User), 
    CONSTRAINT FK_Livros foreign key (CFK_Livro) references Table_Livro(Order_Livro)
    ON delete cascade
    ON update cascade
);

select * from Table_reservas;


insert into Table_Cargo(Cargo) values("Gerente"), ("Aluno"), ("Professor"), ("Externo");
insert into Table_Ano_Escolar(Ano_Escolar) values ("1° EF"), ("2° EF"), ("3° EF"), ("4° EF"), ("5° EF"), ("6° EF"), ("7° EF"), ("8° EF"), ("9° EF"), ("1° EM"), ("2° EM"), ("3° EM"), ("Diretoria");
insert into Table_Unidade(Nome_Unidade, Local_Unidade, IMG_Unidade, Descricao_Retirada)
values ('SESI Curitiba', 'Av. Marechal Floriano Peixoto, 4585, Curitiba', "Sesi Boqueirao.jpg", 'Centro de educação, saúde e lazer; oferece cursos e atividades culturais.'),
('SESI São José dos Pinhais', 'Rua Jacob Macanhan, 221, São José dos Pinhais', "Sesi Sao Jose.jpg", 'Unidade focada em educação, com infraestrutura para esportes e lazer.'),
('SESI Ponta Grossa', 'Rua Dr. Colares, 285, Ponta Grossa', "Sesi Ponta Grossa.jpg", 'Oferece serviços de educação e eventos culturais, com ampla área de lazer.'),
('SESI Cascavel', 'Rua Minas Gerais, 221, Cascavel', "Sesi Cascavel.jpg", 'Centro de educação e atividades esportivas; promove eventos comunitários.'),
('SESI Londrina', 'Av. Duque de Caxias, 1234, Londrina', "Sesi Londrina.jpg", 'Unidade que disponibiliza educação, saúde e atividades recreativas.'),
('SESI Internacional Curitiba', 'Av. Presidente Kennedy, 108, Curitiba', "Sesi Internacional Curitiba.jpg", 'Unidade com foco em educação internacional e intercâmbio cultural.'),
('SESI Industrial Curitiba', 'Rua Jorge Schimmelpfeng, 2200, Curitiba', "Sesi CIC.jpg", 'Centro voltado para educação técnica e industrial, com infraestrutura moderna.');

INSERT INTO Table_Livro (CD_Livro, Nome_Livro, Autor_Livro, QTD_estoque, Numb_Paginas, Edicao_Livro, Descricao_Livro, IMG_Livro, CFK_Unidade)
VALUES 
('320C111L2021', 'A Longa Marcha', 'King, Stephen', 10, 320, 1, 'Romance distópico que acompanha uma competição mortal onde apenas um sobreviverá. A história é cheia de suspense e drama, mostrando os desafios físicos e mentais dos competidores.', '001.320C111L2021.A Longa Marcha - Stephen King.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('480C222P2018', 'Pequenos Incêndios por Toda Parte', 'Ng, Celeste', 6, 480, 1, 'Explora as complexidades da maternidade e os segredos de uma comunidade suburbana. As relações entre as famílias e as consequências de suas ações são centrais na narrativa.', '002.480C222P2018.Pequenos Incêndios por Toda Parte - Celeste Ng.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('400B333O2010', 'O Código Da Vinci', 'Brown, Dan', 15, 400, 1, 'Thriller que segue Robert Langdon enquanto ele desvenda segredos escondidos no Louvre. Cheio de mistérios e reviravoltas, este livro prende a atenção do leitor do início ao fim.', '003.400B333O2010.O Código Da Vinci - Dan Brown.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('350A444N2000', 'A Menina que Roubava Livros', 'Zusak, Markus', 8, 350, 1, 'A história de uma jovem na Alemanha nazista que encontra consolo nos livros roubados. A narrativa é emocionante e tocante, destacando a importância da literatura em tempos difíceis.', '004.350A444N2000.A Menina que Roubava Livros - Markus Zusak.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('270G555G1995', 'Guerra dos Tronos', 'Martin, George R. R.', 20, 270, 1, 'Primeiro livro da série As Crônicas de Gelo e Fogo, que introduz os conflitos entre as famílias nobres. Uma saga épica cheia de intrigas, batalhas e personagens complexos.', '005.270G555G1995.Guerra dos Tronos - George R. R. Martin.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('390G666F2011', 'Fahrenheit 451', 'Bradbury, Ray', 12, 390, 1, 'Romance distópico sobre um futuro onde os livros são proibidos e queimados. A história aborda temas de censura, liberdade de expressão e o valor do conhecimento.', '006.390G666F2011.Fahrenheit 451-Ray Bradbury.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('450D777D2007', 'Divergente', 'Roth, Veronica', 9, 450, 1, 'Em uma Chicago futurista, Beatrice Prior deve escolher entre cinco facções para definir sua identidade. A narrativa explora escolhas pessoais, coragem e as consequências de desafiar o sistema.', '007.450D777D2007.Divergente - Veronica Roth.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('320R888C2019', 'Corte de Espinhos e Rosas', 'Maas, Sarah J.', 7, 320, 1, 'Romance de fantasia que segue Feyre Archeron enquanto navega por um mundo de feéricos e intrigas. Com uma trama envolvente e rica em detalhes, a história cativa os fãs do gênero.', '008.320R888C2019.Corte de Espinhos e Rosas - Sarah J. Maas.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('280L999O2012', 'O Lado Bom da Vida', 'Quick, Matthew', 10, 280, 1, 'Um homem tenta reconstruir sua vida após um colapso mental com a ajuda de uma mulher igualmente quebrada. O livro aborda temas de superação, amor e as dificuldades dos transtornos mentais.', '009.280L999O2012.O Lado Bom da Vida - Matthew Quick.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('310P101T2015', 'A Tumba dos Ancestrais', 'Canavan, Trudi', 5, 310, 1, 'Uma aventura épica de fantasia com magos e segredos antigos. A narrativa leva os leitores a um mundo mágico cheio de mistérios e desafios, com personagens cativantes e tramas complexas.', '010.310P101T2015.A Tumba dos Ancestrais - Trudi Canavan.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('290M202S2020', 'Sapiens: Uma Breve História da Humanidade', 'Harari, Yuval Noah', 14, 290, 1, 'Exploração das principais revoluções que moldaram a humanidade. O autor aborda a evolução da espécie humana, destacando eventos chave que influenciaram nossa sociedade e cultura atuais.', '011.290M202S2020.Sapiens Uma Breve História da Humanidade - Yuval Noah Harari.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('410H303V2016', 'A Vida Invisível de Addie LaRue', 'Schwab, V. E.', 8, 410, 1, 'A história de uma mulher que faz um pacto para viver para sempre, mas é esquecida por todos que conhece. Com uma narrativa envolvente, o livro explora temas de imortalidade e solidão.', '012.410H303V2016.A Vida Invisível de Addie LaRue - V. E. Schwab.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('330C404M2008', 'Mar de Tranquilidade', 'Mandel, Emily St. John', 10, 330, 1, 'Um romance que explora vidas entrelaçadas e as consequências de um ato de violência. A história é rica em detalhes e personagens, oferecendo uma reflexão sobre a condição humana.', '013.330C404M2008.Mar de Tranquilidade - Emily St. John Mandel.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('360B505D2017', 'Duna', 'Herbert, Frank', 7, 360, 1, 'Clássico da ficção científica sobre política, religião e poder em um planeta deserto. A narrativa é complexa e cheia de intrigas, com personagens memoráveis e um mundo ricamente detalhado.', '014.360B505D2017.Duna - Frank Herbert.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('380W606S2014', 'Sangue e Cinzas', 'Armentrout, Jennifer L.', 9, 380, 1, 'Romance de fantasia com uma protagonista forte e misteriosa. A história combina elementos de ação, romance e fantasia, cativando os leitores com sua trama envolvente e personagens bem desenvolvidos.', '015.380W606S2014.Sangue e Cinzas - Jennifer L. Armentrout.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('430K707M2013', 'Mistborn: O Império Final', 'Sanderson, Brandon', 12, 430, 1, 'Primeiro livro da série Mistborn, onde um grupo de rebeldes planeja derrubar um império milenar. A narrativa é cheia de reviravoltas, com um sistema de magia único e personagens complexos.', '016.430K707M2013.Mistborn O Imperio Final - Brandon Sanderson.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('420F808A2010', 'A Arte da Guerra', 'Tzu, Sun', 20, 420, 1, 'Clássico tratado militar chinês sobre estratégia e tática. Embora escrito há milhares de anos, os ensinamentos do livro são aplicáveis em diversas áreas modernas, incluindo negócios e política.', '017.420F808A2010.A Arte da Guerra - Sun Tzu.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('360G909C2005', 'Cem Anos de Solidão', 'García Márquez, Gabriel', 18, 360, 1, 'História épica da família Buendía em uma aldeia fictícia na Colômbia. Com uma narrativa rica e detalhada, o livro explora temas de solidão, amor e a passagem do tempo.', '018.360G909C2005.Cem Anos de Solidao - Gabriel Garcia Marquez.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('290J010B2022', 'O Projeto Rosie', 'Simpson, Graeme', 11, 290, 1, 'Uma comédia romântica sobre um geneticista em busca de uma parceira ideal. O livro combina humor e romance, explorando a natureza das relações humanas.', '019.310K111B2018.O Prisioneiro do Ceu - Carlos Ruiz Zafon.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('410S121A2018', 'Anatomia de um Médico', 'Gawande, Atul', 6, 410, 1, 'Uma análise profunda sobre a prática da medicina. O autor explora desafios éticos, dilemas morais e o impacto da tecnologia na saúde.', '020.340S222R2009.O Senhor das Moscas - William Golding.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('430A232C2021', 'Cruzando o Caminho', 'Morrison, Toni', 9, 430, 1, 'Uma narrativa poderosa que aborda questões de raça e identidade. O livro convida os leitores a refletirem sobre o passado e suas implicações no presente.', '021.350C333H2011.O Sol e Para Todos - Harper Lee.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('280B343D2002', 'O diário de Anne Frank', 'Frank, Anne', 5, 280, 1, 'Relato emocionante da vida de uma jovem judia durante a Segunda Guerra Mundial. O diário é uma poderosa reflexão sobre a guerra, a esperança e a resiliência humana.', '022.390T444T2022.A Travessia - Richard Paul Evans.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('440M454E2019', 'A Escola do Bem e do Mal', 'Chainani, Soman', 8, 440, 1, 'Uma nova versão dos contos de fadas clássicos. A história explora amizade, coragem e a luta entre o bem e o mal em um mundo mágico.', '023.410H555H2017.O Hobbit - J. R. R. Tolkien.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('390C565F2014', 'O Silmarillion', 'Tolkien, J. R. R.', 12, 390, 1, 'Compilação da mitologia e história da Terra Média. O livro é uma rica fonte de conhecimento para os fãs de O Senhor dos Anéis e O Hobbit.', '024.370B666G2019.O Guia do Mochileiro das Galaxias - Douglas Adams.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('370R676L2010', 'O Último Guardião', 'Kellerman, Jonathan', 15, 370, 1, 'Um thriller psicológico que explora a mente humana e os limites da moralidade. A narrativa é intensa e cheia de reviravoltas, mantendo o leitor preso até o final.', '025.280P777D2016.1984 - George Orwell.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('340H787C2001', 'O Hobbit', 'Tolkien, J. R. R.', 18, 340, 1, 'Clássico da literatura fantástica que segue Bilbo Bolseiro em sua jornada. O livro é uma introdução ao mundo da Terra Média, cheio de criaturas mágicas e aventuras.', '026.350S888B2014.A Biblioteca Invisível - Genevieve Cogman.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('310N898P2017', 'O Que o Sol Faz com as Flores', 'Cole, Rupi', 9, 310, 1, 'Uma coleção de poesias que exploram o amor, a perda e a feminilidade. A escrita é sensível e impactante, tocando o coração dos leitores.', '027.320L999C2011.O Código Élfico - J. R. R. Tolkien.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('430K909T2023', 'O Mestre das Chaves', 'Sullivan, Michael J.', 6, 430, 1, 'Uma aventura de fantasia que segue um jovem em busca de seu destino. A narrativa é repleta de magia, ação e amizade.', '028.360P101L2013.A Peste - Albert Camus.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('340J010B2008', 'A Culpa é das Estrelas', 'Green, John', 11, 340, 1, 'Uma história de amor entre dois adolescentes com câncer. O livro é emocionante e aborda a fragilidade da vida e a importância de aproveitar cada momento.', '029.420K202R2020.O Retrato de Dorian Gray - Oscar Wilde.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('350J111S2020', 'A Guerra dos Mundos', 'Wells, H. G.', 5, 350, 1, 'Uma história de ficção científica que narra a invasão alienígena na Terra. O livro é um clássico do gênero, cheio de ação e reflexão sobre a condição humana.', '030.310H303S2005.Senhor dos Aneis O Retorno do Rei - J. R. R. Tolkien.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('360K222E2022', 'O Homem Invisível', 'Wells, H. G.', 7, 360, 1, 'A narrativa de um cientista que descobre o segredo da invisibilidade e as consequências de sua descoberta. O livro é uma reflexão sobre poder e moralidade.', '031.340D404F2015.Fundacao - Isaac Asimov.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('340M333A2021', 'A Estrada', 'McCarthy, Cormac', 8, 340, 1, 'Um pai e seu filho atravessam um mundo pós-apocalíptico em busca de sobrevivência. A narrativa é profunda, explorando o amor, a esperança e a brutalidade da vida.', '032.390T505D2010.Duna Messias de Duna - Frank Herbert.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('350P444F2019', 'O Conto da Aia', 'Atwood, Margaret', 10, 350, 1, 'Uma distopia que retrata um futuro totalitário onde as mulheres são subjugadas. A protagonista luta contra a opressão e busca sua liberdade em um mundo cruel.', '033.380C606G2018.Guerra Mundial Z - Max Brooks.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('380S555F2015', 'O Senhor dos Anéis: A Sociedade do Anel', 'Tolkien, J. R. R.', 12, 380, 1, 'A jornada épica para destruir o Um Anel. Uma história de amizade, coragem e sacrifício em um mundo repleto de magia e aventura.', '034.430F707O2003.Orgulho e Preconceito - Jane Austen.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('290H666R2020', 'Como Fazer Amigos e Influenciar Pessoas', 'Carnegie, Dale', 14, 290, 1, 'Clássico sobre relacionamentos e comunicação. O autor oferece dicas e técnicas para melhorar habilidades sociais e influenciar positivamente as pessoas.', '035.280R808E2014.E o Vento Levou - Margaret Mitchell.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1)),
('360D777M2018', 'Morte e Vida Severina', 'Carpeaux, João Cabral de Melo', 9, 360, 1, 'Poema que retrata a vida do nordestino, suas lutas e esperanças. A obra é uma crítica social e um tributo à cultura brasileira.', '036.350G909A2011.Admirável Mundo Novo - Aldous Huxley.jpg', (SELECT CD_Unidade FROM Table_Unidade ORDER BY RAND() LIMIT 1));


-- falta

INSERT INTO Table_User (ID_Aluno, NameUser, Nome_Completo, Senha, IMG_User, CFK_Ano, CFK_Cargo, CFK_Unidade) VALUES ('123456789', 'g', 'João Pedro Doe', '123', 'Image1.png', 13, 1, 1);
insert into table_adm(NameUser_Adm, Senha_Adm, CFK_User) values("Skyline", "Pass123", 1);
select Table_Livro.Nome_Livro, Table_Unidade.Nome_Unidade, Table_Livro.Descricao_Livro from Table_Livro Inner Join Table_Unidade on Table_Unidade.CD_Unidade = Table_Livro.CFK_Unidade where Table_Livro.CD_Livro = "320R888C2019";	

select Table_Livro.Nome_Livro, Table_Livro.CD_Livro, Table_Unidade.Nome_Unidade, Table_Livro.Descricao_Livro, Table_Unidade.CD_Unidade from Table_Livro Inner Join Table_Unidade on Table_Unidade.CD_Unidade = Table_Livro.CFK_Unidade;


select Table_User.ID_Aluno,
    Table_User.NameUser,
    Table_User.Nome_Completo,
    Table_User.Senha,	
    Table_User.IMG_User,
    Table_Ano_Escolar.Ano_Escolar,
	Table_Cargo.Cargo,
    Table_Unidade.Nome_Unidade 
    from Table_User 
    inner join Table_Ano_Escolar on Table_User.CFK_Ano = Table_Ano_Escolar.CD_Ano_Escolar
    inner join Table_Cargo on Table_User.CFK_Cargo = Table_Cargo.CD_Cargo
    inner join Table_Unidade on Table_User.CFK_Unidade = Table_Unidade.CD_Unidade;



Select * From Table_Cargo;
Select * From Table_Ano_Escolar;
Select * From Table_Unidade;
Select * From Table_Livro;
Select * From Table_User;
Select * From Table_Historico;
Select * From Table_reservas;
Select * From Table_Adm;

-- insert into table_historico(DT_reserva, DT_devolucao, CFK_Livro, CFK_User) values('', '', , );

-- DELETE FROM Table_User WHERE CD_User = 7;

-- update Table_User set ID_Aluno="01242", NameUser="g", Nome_Completo="Gabriel", Senha="123", CFK_Cargo=1, CFK_Unidade =1, CFK_Ano=1 where CD_User=1 LIMIT 1;

SELECT Table_Reservas.CD_Reservas, Table_Livro.Nome_Livro, Table_reservas.DT_reserva, Table_reservas.DT_previsao_devolucao FROM Table_reservas INNER JOIN Table_Livro ON Table_Reservas.CFK_Livro = Table_Livro.Order_Livro where Table_Reservas.CFK_User = 1;

select * from Table_User where NameUser = "g" OR Senha = "123";

SELECT 
    u.CD_User "Index",
    u.ID_Aluno as "ID",
    u.Nome_Completo as "Nome Completo",
    u.NameUser as "NameUser",
    c.Cargo as "Cargo",
    a.Ano_Escolar as "Ano",
    un.Nome_Unidade as "Unidade",
    COUNT(r.CD_Reservas) AS "Numb Reservas",
    COUNT(h.CD_Hist) AS "Numb Histórico"
FROM 
    Table_User u
INNER JOIN 
    Table_Cargo c ON u.CFK_Cargo = c.CD_Cargo
INNER JOIN 
    Table_Ano_Escolar a ON u.CFK_Ano = a.CD_Ano_Escolar
INNER JOIN 
    Table_Unidade un ON u.CFK_Unidade = un.CD_Unidade
LEFT JOIN 
    Table_Reservas r ON u.CD_User = r.CFK_User
LEFT JOIN 
    Table_Historico h ON u.CD_User = h.CFK_User
GROUP BY 
    u.CD_User, u.ID_Aluno, u.Nome_Completo, u.NameUser , u.IMG_User, c.Cargo, a.Ano_Escolar, un.Nome_Unidade;
    
    
    select * from table_historico where CFK_User = 1;
    