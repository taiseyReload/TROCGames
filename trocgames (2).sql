-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 30/11/2023 às 00:52
-- Versão do servidor: 10.4.28-MariaDB
-- Versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `trocgames`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `carrinho`
--

CREATE TABLE `carrinho` (
  `id` int(11) NOT NULL,
  `id_ficha` int(11) DEFAULT NULL,
  `quantidade` int(11) DEFAULT NULL,
  `id_produtos` int(11) NOT NULL,
  `data_adic` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `situacao` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `carrinho`
--

INSERT INTO `carrinho` (`id`, `id_ficha`, `quantidade`, `id_produtos`, `data_adic`, `situacao`) VALUES
(36, 2, 1, 11, '2023-11-29 22:58:17', 0),
(44, 3, 1, 16, '2023-11-29 22:58:17', 0),
(45, 4, 1, 17, '2023-11-29 22:58:17', 0),
(46, 5, 1, 6, '2023-11-29 22:58:17', 0),
(47, 6, 1, 7, '2023-11-29 22:58:17', 0),
(48, 7, 1, 16, '2023-11-29 23:04:46', 0),
(49, 8, 1, 14, '2023-11-29 23:04:46', 0),
(50, 9, 1, 5, '2023-11-29 23:05:18', 0),
(51, 10, 1, 11, '2023-11-29 23:23:40', 0),
(52, 10, 1, 2, '2023-11-29 23:23:40', 0),
(55, 11, 1, 8, '2023-11-29 23:29:38', 0),
(56, 11, 1, 20, '2023-11-29 23:29:38', 0),
(57, 12, 1, 20, '2023-11-29 23:32:32', 0),
(58, 12, 1, 19, '2023-11-29 23:32:32', 0),
(59, 13, 1, 19, '2023-11-29 23:33:12', 0),
(60, 14, 1, 20, '2023-11-29 23:33:51', 0),
(61, 15, 1, 19, '2023-11-29 23:36:46', 0),
(62, 16, 1, 8, '2023-11-29 23:37:50', 0),
(63, 17, 1, 20, '2023-11-29 23:41:10', 0),
(64, 18, 1, 19, '2023-11-29 23:41:43', 0),
(65, 19, 1, 20, '2023-11-29 23:44:32', 0),
(66, 20, 1, 8, '2023-11-29 23:46:00', 0),
(67, 21, 1, 22, '2023-11-29 23:49:04', 0),
(68, 22, 1, 23, '2023-11-29 23:49:12', 0),
(69, 22, 1, 7, '2023-11-29 23:50:49', 0),
(70, 22, 1, 23, '2023-11-29 23:50:49', 0),
(71, 23, 1, 20, '2023-11-29 23:50:49', 0),
(72, 23, 1, 8, '2023-11-29 23:50:49', 0);

-- --------------------------------------------------------

--
-- Estrutura para tabela `categorias`
--

CREATE TABLE `categorias` (
  `id` int(11) NOT NULL,
  `nome` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `categorias`
--

INSERT INTO `categorias` (`id`, `nome`) VALUES
(1, 'Consoles'),
(2, 'Jogos'),
(3, 'Acessórios'),
(4, 'Tudo');

-- --------------------------------------------------------

--
-- Estrutura para tabela `marcas`
--

CREATE TABLE `marcas` (
  `id` int(11) NOT NULL,
  `nome` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `marcas`
--

INSERT INTO `marcas` (`id`, `nome`) VALUES
(1, 'Nintendo'),
(2, 'Playstation'),
(3, 'Xbox');

-- --------------------------------------------------------

--
-- Estrutura para tabela `produtos`
--

CREATE TABLE `produtos` (
  `id` int(11) NOT NULL,
  `nome` varchar(500) DEFAULT NULL,
  `preco` double DEFAULT NULL,
  `id_categorias` int(11) NOT NULL,
  `id_marcas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `produtos`
--

INSERT INTO `produtos` (`id`, `nome`, `preco`, `id_categorias`, `id_marcas`) VALUES
(1, 'Nintendo Switch OLED', 2249.99, 1, 1),
(2, 'Playstation 5', 3699.99, 1, 2),
(3, 'Xbox Series X', 4299.99, 1, 3),
(4, 'DRAGON QUEST® XI S: Echoes of an Elusive Age™ - Definitive Edition', 169.9, 2, 2),
(5, 'The Legend of Zelda: Tears of the Kingdom™', 357, 2, 1),
(6, 'Persona 5 Royal', 289, 2, 3),
(7, 'Joy Con Branco', 420, 3, 1),
(8, 'Dualshock 4', 284.9, 3, 2),
(9, 'Xbox Controller', 395.5, 3, 3),
(10, 'Sonic Frontiers', 250, 2, 2),
(11, 'God of War Ragnarök', 350, 2, 2),
(12, 'Super Mario Odyssey', 299, 2, 1),
(13, 'Kirby and the Forgotten Land', 299, 2, 1),
(14, 'Nintendo 3DS', 620.2, 1, 1),
(15, 'Playstation 3', 679.9, 1, 2),
(16, 'Tekken 7 ', 169.9, 2, 2),
(17, 'Banjo-Kazooie', 29.9, 2, 3),
(18, 'Marvel\'s Spider-Man', 189.99, 2, 2),
(19, 'Uncharted 4', 111.99, 2, 2),
(20, 'The Last of Us Part II', 249.99, 2, 2),
(21, 'Playstation 4', 2499.99, 1, 2),
(22, 'Gears 5', 199.99, 2, 3),
(23, 'Persona 4 Golden', 99.99, 2, 1),
(26, 'Persona 3 Portable', 99.99, 2, 2);

-- --------------------------------------------------------

--
-- Estrutura stand-in para view `view_carrinho`
-- (Veja abaixo para a visão atual)
--
CREATE TABLE `view_carrinho` (
`id` int(11)
,`id_ficha` int(11)
,`quantidade` int(11)
,`Produto` varchar(500)
,`preco` double
);

-- --------------------------------------------------------

--
-- Estrutura stand-in para view `view_produtos`
-- (Veja abaixo para a visão atual)
--
CREATE TABLE `view_produtos` (
`id` int(11)
,`nome` varchar(500)
,`preco` double
,`id_categorias` int(11)
,`id_marcas` int(11)
);

-- --------------------------------------------------------

--
-- Estrutura stand-in para view `view_produtosnintendo`
-- (Veja abaixo para a visão atual)
--
CREATE TABLE `view_produtosnintendo` (
`Id` int(11)
,`Nome` varchar(500)
,`Preço` double
,`Categoria` varchar(45)
);

-- --------------------------------------------------------

--
-- Estrutura stand-in para view `view_produtosplaystation`
-- (Veja abaixo para a visão atual)
--
CREATE TABLE `view_produtosplaystation` (
`Id` int(11)
,`Nome` varchar(500)
,`Preço` double
,`Categoria` varchar(45)
);

-- --------------------------------------------------------

--
-- Estrutura stand-in para view `view_produtosxbox`
-- (Veja abaixo para a visão atual)
--
CREATE TABLE `view_produtosxbox` (
`Id` int(11)
,`Nome` varchar(500)
,`Preço` double
,`Categoria` varchar(45)
);

-- --------------------------------------------------------

--
-- Estrutura para view `view_carrinho`
--
DROP TABLE IF EXISTS `view_carrinho`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_carrinho`  AS SELECT `carrinho`.`id` AS `id`, `carrinho`.`id_ficha` AS `id_ficha`, `carrinho`.`quantidade` AS `quantidade`, `produtos`.`nome` AS `Produto`, `produtos`.`preco` AS `preco` FROM (`carrinho` join `produtos` on(`produtos`.`id` = `carrinho`.`id_produtos`)) WHERE `carrinho`.`situacao` = 1 ;

-- --------------------------------------------------------

--
-- Estrutura para view `view_produtos`
--
DROP TABLE IF EXISTS `view_produtos`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_produtos`  AS SELECT `produtos`.`id` AS `id`, `produtos`.`nome` AS `nome`, `produtos`.`preco` AS `preco`, `produtos`.`id_categorias` AS `id_categorias`, `produtos`.`id_marcas` AS `id_marcas` FROM `produtos` ;

-- --------------------------------------------------------

--
-- Estrutura para view `view_produtosnintendo`
--
DROP TABLE IF EXISTS `view_produtosnintendo`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_produtosnintendo`  AS SELECT `produtos`.`id` AS `Id`, `produtos`.`nome` AS `Nome`, `produtos`.`preco` AS `Preço`, `categorias`.`nome` AS `Categoria` FROM (`produtos` join `categorias` on(`produtos`.`id_categorias` = `categorias`.`id`)) WHERE `produtos`.`id_marcas` = 1 ;

-- --------------------------------------------------------

--
-- Estrutura para view `view_produtosplaystation`
--
DROP TABLE IF EXISTS `view_produtosplaystation`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_produtosplaystation`  AS SELECT `produtos`.`id` AS `Id`, `produtos`.`nome` AS `Nome`, `produtos`.`preco` AS `Preço`, `categorias`.`nome` AS `Categoria` FROM (`produtos` join `categorias` on(`produtos`.`id_categorias` = `categorias`.`id`)) WHERE `produtos`.`id_marcas` = 2 ;

-- --------------------------------------------------------

--
-- Estrutura para view `view_produtosxbox`
--
DROP TABLE IF EXISTS `view_produtosxbox`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_produtosxbox`  AS SELECT `produtos`.`id` AS `Id`, `produtos`.`nome` AS `Nome`, `produtos`.`preco` AS `Preço`, `categorias`.`nome` AS `Categoria` FROM (`produtos` join `categorias` on(`produtos`.`id_categorias` = `categorias`.`id`)) WHERE `produtos`.`id_marcas` = 3 ;

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `carrinho`
--
ALTER TABLE `carrinho`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_Carrinho_Produtos1_idx` (`id_produtos`);

--
-- Índices de tabela `categorias`
--
ALTER TABLE `categorias`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `marcas`
--
ALTER TABLE `marcas`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `produtos`
--
ALTER TABLE `produtos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_Produtos_Categorias_idx` (`id_categorias`),
  ADD KEY `fk_Produtos_Marcas1_idx` (`id_marcas`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `carrinho`
--
ALTER TABLE `carrinho`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=73;

--
-- AUTO_INCREMENT de tabela `categorias`
--
ALTER TABLE `categorias`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `marcas`
--
ALTER TABLE `marcas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `produtos`
--
ALTER TABLE `produtos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `carrinho`
--
ALTER TABLE `carrinho`
  ADD CONSTRAINT `fk_Carrinho_Produtos1` FOREIGN KEY (`id_produtos`) REFERENCES `produtos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Restrições para tabelas `produtos`
--
ALTER TABLE `produtos`
  ADD CONSTRAINT `fk_Produtos_Categorias` FOREIGN KEY (`id_categorias`) REFERENCES `categorias` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Produtos_Marcas1` FOREIGN KEY (`id_marcas`) REFERENCES `marcas` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
