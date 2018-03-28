use world;
drop table if exists MarketData;
CREATE TABLE IF NOT EXISTS `MarketData` (
  `Ticker` char(5) NOT NULL,
  `Date` date NOT NULL,
  `Open` double NOT NULL,
  `High` double NOT NULL,
  `Low` double NOT NULL,
  `Close` double NOT NULL,
  `Volume` double DEFAULT NULL,
  PRIMARY KEY (`Ticker`, `Date`)
)