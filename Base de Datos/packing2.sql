-- MySQL dump 10.13  Distrib 8.0.13, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: packing
-- ------------------------------------------------------
-- Server version	8.0.13

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbl_bandeja`
--

DROP TABLE IF EXISTS `tbl_bandeja`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_bandeja` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(50) NOT NULL,
  `Peso` decimal(5,3) NOT NULL DEFAULT '0.000',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bandeja`
--

LOCK TABLES `tbl_bandeja` WRITE;
/*!40000 ALTER TABLE `tbl_bandeja` DISABLE KEYS */;
INSERT INTO `tbl_bandeja` VALUES (1,'Torito',1.800),(2,'Blanco/Amarillo',1.900),(3,'Verde',1.702),(4,'Azul',1.500),(5,'Rojo',1.550);
/*!40000 ALTER TABLE `tbl_bandeja` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cliente`
--

DROP TABLE IF EXISTS `tbl_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_cliente` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Codigo` varchar(50) NOT NULL,
  `Cliente` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=1730 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cliente`
--

LOCK TABLES `tbl_cliente` WRITE;
/*!40000 ALTER TABLE `tbl_cliente` DISABLE KEYS */;
INSERT INTO `tbl_cliente` VALUES (6,'6','Bazo'),(7,'7','cool&go'),(509,'1001','Cliente 1'),(510,'1002','Cliente 2'),(511,'1003','Cliente 3'),(512,'1004','Cliente 4'),(513,'1005','Cliente 5'),(514,'1006','Cliente 6'),(515,'1007','Cliente 7'),(516,'1008','Cliente 8'),(517,'1009','Cliente 9'),(518,'1010','Cliente 10'),(519,'1011','Cliente 11'),(520,'1012','Cliente 12'),(521,'1013','Cliente 13'),(522,'1014','Cliente 14'),(523,'1015','Cliente 15'),(524,'1016','Cliente 16'),(525,'1017','Cliente 17'),(526,'1018','Cliente 18'),(527,'1019','Cliente 19'),(528,'1020','Cliente 20'),(529,'1021','Cliente 21'),(530,'1022','Cliente 22'),(531,'1023','Cliente 23'),(532,'1024','Cliente 24'),(533,'1025','Cliente 25'),(534,'1026','Cliente 26'),(535,'1027','Cliente 27'),(536,'1028','Cliente 28'),(537,'1029','Cliente 29'),(538,'1030','Cliente 30'),(539,'1031','Cliente 31'),(540,'1032','Cliente 32'),(541,'1033','Cliente 33'),(542,'1034','Cliente 34'),(543,'1035','Cliente 35'),(544,'1036','Cliente 36'),(545,'1037','Cliente 37'),(546,'1038','Cliente 38'),(547,'1039','Cliente 39'),(548,'1040','Cliente 40'),(549,'1041','Cliente 41'),(550,'1042','Cliente 42'),(551,'1043','Cliente 43'),(552,'1044','Cliente 44'),(553,'1045','Cliente 45'),(554,'1046','Cliente 46'),(555,'1047','Cliente 47'),(556,'1048','Cliente 48'),(557,'1049','Cliente 49'),(558,'1050','Cliente 50'),(559,'1051','Cliente 51'),(560,'1052','Cliente 52'),(561,'1053','Cliente 53'),(562,'1054','Cliente 54'),(563,'1055','Cliente 55'),(564,'1056','Cliente 56'),(565,'1057','Cliente 57'),(566,'1058','Cliente 58'),(567,'1059','Cliente 59'),(568,'1060','Cliente 60'),(569,'1061','Cliente 61'),(570,'1062','Cliente 62'),(571,'1063','Cliente 63'),(572,'1064','Cliente 64'),(573,'1065','Cliente 65'),(574,'1066','Cliente 66'),(575,'1067','Cliente 67'),(576,'1068','Cliente 68'),(577,'1069','Cliente 69'),(578,'1070','Cliente 70'),(579,'1071','Cliente 71'),(580,'1072','Cliente 72'),(581,'1073','Cliente 73'),(582,'1074','Cliente 74'),(583,'1075','Cliente 75'),(584,'1076','Cliente 76'),(585,'1077','Cliente 77'),(586,'1078','Cliente 78'),(587,'1079','Cliente 79'),(588,'1080','Cliente 80'),(589,'1081','Cliente 81'),(590,'1082','Cliente 82'),(591,'1083','Cliente 83'),(592,'1084','Cliente 84'),(593,'1085','Cliente 85'),(594,'1086','Cliente 86'),(595,'1087','Cliente 87'),(596,'1088','Cliente 88'),(597,'1089','Cliente 89'),(598,'1090','Cliente 90'),(599,'1091','Cliente 91'),(600,'1092','Cliente 92'),(601,'1093','Cliente 93'),(602,'1094','Cliente 94'),(603,'1095','Cliente 95'),(604,'1096','Cliente 96'),(605,'1097','Cliente 97'),(606,'1098','Cliente 98'),(607,'1099','Cliente 99'),(608,'1100','Cliente 100'),(609,'1101','Cliente 101'),(610,'1102','Cliente 102'),(611,'1103','Cliente 103'),(612,'1104','Cliente 104'),(613,'1105','Cliente 105'),(614,'1106','Cliente 106'),(615,'1107','Cliente 107'),(616,'1108','Cliente 108'),(617,'1109','Cliente 109'),(618,'1110','Cliente 110'),(619,'1111','Cliente 111'),(620,'1112','Cliente 112'),(621,'1113','Cliente 113'),(622,'1114','Cliente 114'),(623,'1115','Cliente 115'),(624,'1116','Cliente 116'),(625,'1117','Cliente 117'),(626,'1118','Cliente 118'),(627,'1119','Cliente 119'),(628,'1120','Cliente 120'),(629,'1121','Cliente 121'),(630,'1122','Cliente 122'),(631,'1123','Cliente 123'),(632,'1124','Cliente 124'),(633,'1125','Cliente 125'),(634,'1126','Cliente 126'),(635,'1127','Cliente 127'),(636,'1128','Cliente 128'),(637,'1129','Cliente 129'),(638,'1130','Cliente 130'),(639,'1131','Cliente 131'),(640,'1132','Cliente 132'),(641,'1133','Cliente 133'),(642,'1134','Cliente 134'),(643,'1135','Cliente 135'),(644,'1136','Cliente 136'),(645,'1137','Cliente 137'),(646,'1138','Cliente 138'),(647,'1139','Cliente 139'),(648,'1140','Cliente 140'),(649,'1141','Cliente 141'),(650,'1142','Cliente 142'),(651,'1143','Cliente 143'),(652,'1144','Cliente 144'),(653,'1145','Cliente 145'),(654,'1146','Cliente 146'),(655,'1147','Cliente 147'),(656,'1148','Cliente 148'),(657,'1149','Cliente 149'),(658,'1150','Cliente 150'),(659,'1151','Cliente 151'),(660,'1152','Cliente 152'),(661,'1153','Cliente 153'),(662,'1154','Cliente 154'),(663,'1155','Cliente 155'),(664,'1156','Cliente 156'),(665,'1157','Cliente 157'),(666,'1158','Cliente 158'),(667,'1159','Cliente 159'),(668,'1160','Cliente 160'),(669,'1161','Cliente 161'),(670,'1162','Cliente 162'),(671,'1163','Cliente 163'),(672,'1164','Cliente 164'),(673,'1165','Cliente 165'),(674,'1166','Cliente 166'),(675,'1167','Cliente 167'),(676,'1168','Cliente 168'),(677,'1169','Cliente 169'),(678,'1170','Cliente 170'),(679,'1171','Cliente 171'),(680,'1172','Cliente 172'),(681,'1173','Cliente 173'),(682,'1174','Cliente 174'),(683,'1175','Cliente 175'),(684,'1176','Cliente 176'),(685,'1177','Cliente 177'),(686,'1178','Cliente 178'),(687,'1179','Cliente 179'),(688,'1180','Cliente 180'),(689,'1181','Cliente 181'),(690,'1182','Cliente 182'),(691,'1183','Cliente 183'),(692,'1184','Cliente 184'),(693,'1185','Cliente 185'),(694,'1186','Cliente 186'),(695,'1187','Cliente 187'),(696,'1188','Cliente 188'),(697,'1189','Cliente 189'),(698,'1190','Cliente 190'),(699,'1191','Cliente 191'),(700,'1192','Cliente 192'),(701,'1193','Cliente 193'),(702,'1194','Cliente 194'),(703,'1195','Cliente 195'),(704,'1196','Cliente 196'),(705,'1197','Cliente 197'),(706,'1198','Cliente 198'),(707,'1199','Cliente 199'),(708,'1200','Cliente 200'),(709,'1201','Cliente 201'),(710,'1202','Cliente 202'),(711,'1203','Cliente 203'),(712,'1204','Cliente 204'),(713,'1205','Cliente 205'),(714,'1206','Cliente 206'),(715,'1207','Cliente 207'),(716,'1208','Cliente 208'),(717,'1209','Cliente 209'),(718,'1210','Cliente 210'),(719,'1211','Cliente 211'),(720,'1212','Cliente 212'),(721,'1213','Cliente 213'),(722,'1214','Cliente 214'),(723,'1215','Cliente 215'),(724,'1216','Cliente 216'),(725,'1217','Cliente 217'),(726,'1218','Cliente 218'),(727,'1219','Cliente 219'),(728,'1220','Cliente 220'),(729,'1221','Cliente 221'),(730,'1222','Cliente 222'),(731,'1223','Cliente 223'),(732,'1224','Cliente 224'),(733,'1225','Cliente 225'),(734,'1226','Cliente 226'),(735,'1227','Cliente 227'),(736,'1228','Cliente 228'),(737,'1229','Cliente 229'),(738,'1230','Cliente 230'),(739,'1231','Cliente 231'),(740,'1232','Cliente 232'),(741,'1233','Cliente 233'),(742,'1234','Cliente 234'),(743,'1235','Cliente 235'),(744,'1236','Cliente 236'),(745,'1237','Cliente 237'),(746,'1238','Cliente 238'),(747,'1239','Cliente 239'),(748,'1240','Cliente 240'),(749,'1241','Cliente 241'),(750,'1242','Cliente 242'),(751,'1243','Cliente 243'),(752,'1244','Cliente 244'),(753,'1245','Cliente 245'),(754,'1246','Cliente 246'),(755,'1247','Cliente 247'),(756,'1248','Cliente 248'),(757,'1249','Cliente 249'),(758,'1250','Cliente 250'),(759,'1251','Cliente 251'),(760,'1252','Cliente 252'),(761,'1253','Cliente 253'),(762,'1254','Cliente 254'),(763,'1255','Cliente 255'),(764,'1256','Cliente 256'),(765,'1257','Cliente 257'),(766,'1258','Cliente 258'),(767,'1259','Cliente 259'),(768,'1260','Cliente 260'),(769,'1261','Cliente 261'),(770,'1262','Cliente 262'),(771,'1263','Cliente 263'),(772,'1264','Cliente 264'),(773,'1265','Cliente 265'),(774,'1266','Cliente 266'),(775,'1267','Cliente 267'),(776,'1268','Cliente 268'),(777,'1269','Cliente 269'),(778,'1270','Cliente 270'),(779,'1271','Cliente 271'),(780,'1272','Cliente 272'),(781,'1273','Cliente 273'),(782,'1274','Cliente 274'),(783,'1275','Cliente 275'),(784,'1276','Cliente 276'),(785,'1277','Cliente 277'),(786,'1278','Cliente 278'),(787,'1279','Cliente 279'),(788,'1280','Cliente 280'),(789,'1281','Cliente 281'),(790,'1282','Cliente 282'),(791,'1283','Cliente 283'),(792,'1284','Cliente 284'),(793,'1285','Cliente 285'),(794,'1286','Cliente 286'),(795,'1287','Cliente 287'),(796,'1288','Cliente 288'),(797,'1289','Cliente 289'),(798,'1290','Cliente 290'),(799,'1291','Cliente 291'),(800,'1292','Cliente 292'),(801,'1293','Cliente 293'),(802,'1294','Cliente 294'),(803,'1295','Cliente 295'),(804,'1296','Cliente 296'),(805,'1297','Cliente 297'),(806,'1298','Cliente 298'),(807,'1299','Cliente 299'),(808,'1300','Cliente 300'),(809,'1301','Cliente 301'),(810,'1302','Cliente 302'),(811,'1303','Cliente 303'),(812,'1304','Cliente 304'),(813,'1305','Cliente 305'),(814,'1306','Cliente 306'),(815,'1307','Cliente 307'),(816,'1308','Cliente 308'),(817,'1309','Cliente 309'),(818,'1310','Cliente 310'),(819,'1311','Cliente 311'),(820,'1312','Cliente 312'),(821,'1313','Cliente 313'),(822,'1314','Cliente 314'),(823,'1315','Cliente 315'),(824,'1316','Cliente 316'),(825,'1317','Cliente 317'),(826,'1318','Cliente 318'),(827,'1319','Cliente 319'),(828,'1320','Cliente 320'),(829,'1321','Cliente 321'),(830,'1322','Cliente 322'),(831,'1323','Cliente 323'),(832,'1324','Cliente 324'),(833,'1325','Cliente 325'),(834,'1326','Cliente 326'),(835,'1327','Cliente 327'),(836,'1328','Cliente 328'),(837,'1329','Cliente 329'),(838,'1330','Cliente 330'),(839,'1331','Cliente 331'),(840,'1332','Cliente 332'),(841,'1333','Cliente 333'),(842,'1334','Cliente 334'),(843,'1335','Cliente 335'),(844,'1336','Cliente 336'),(845,'1337','Cliente 337'),(846,'1338','Cliente 338'),(847,'1339','Cliente 339'),(848,'1340','Cliente 340'),(849,'1341','Cliente 341'),(850,'1342','Cliente 342'),(851,'1343','Cliente 343'),(852,'1344','Cliente 344'),(853,'1345','Cliente 345'),(854,'1346','Cliente 346'),(855,'1347','Cliente 347'),(856,'1348','Cliente 348'),(857,'1349','Cliente 349'),(858,'1350','Cliente 350'),(859,'1351','Cliente 351'),(860,'1352','Cliente 352'),(861,'1353','Cliente 353'),(862,'1354','Cliente 354'),(863,'1355','Cliente 355'),(864,'1356','Cliente 356'),(865,'1357','Cliente 357'),(866,'1358','Cliente 358'),(867,'1359','Cliente 359'),(868,'1360','Cliente 360'),(869,'1361','Cliente 361'),(870,'1362','Cliente 362'),(871,'1363','Cliente 363'),(872,'1364','Cliente 364'),(873,'1365','Cliente 365'),(874,'1366','Cliente 366'),(875,'1367','Cliente 367'),(876,'1368','Cliente 368'),(877,'1369','Cliente 369'),(878,'1370','Cliente 370'),(879,'1371','Cliente 371'),(880,'1372','Cliente 372'),(881,'1373','Cliente 373'),(882,'1374','Cliente 374'),(883,'1375','Cliente 375'),(884,'1376','Cliente 376'),(885,'1377','Cliente 377'),(886,'1378','Cliente 378'),(887,'1379','Cliente 379'),(888,'1380','Cliente 380'),(889,'1381','Cliente 381'),(890,'1382','Cliente 382'),(891,'1383','Cliente 383'),(892,'1384','Cliente 384'),(893,'1385','Cliente 385'),(894,'1386','Cliente 386'),(895,'1387','Cliente 387'),(896,'1388','Cliente 388'),(897,'1389','Cliente 389'),(898,'1390','Cliente 390'),(899,'1391','Cliente 391'),(900,'1392','Cliente 392'),(901,'1393','Cliente 393'),(902,'1394','Cliente 394'),(903,'1395','Cliente 395'),(904,'1396','Cliente 396'),(905,'1397','Cliente 397'),(906,'1398','Cliente 398'),(907,'1399','Cliente 399'),(908,'1400','Cliente 400'),(909,'1401','Cliente 401'),(910,'1402','Cliente 402'),(911,'1403','Cliente 403'),(912,'1404','Cliente 404'),(913,'1405','Cliente 405'),(914,'1406','Cliente 406'),(915,'1407','Cliente 407'),(916,'1408','Cliente 408'),(917,'1409','Cliente 409'),(918,'1410','Cliente 410'),(919,'1411','Cliente 411'),(920,'1412','Cliente 412'),(921,'1413','Cliente 413'),(922,'1414','Cliente 414'),(923,'1415','Cliente 415'),(924,'1416','Cliente 416'),(925,'1417','Cliente 417'),(926,'1418','Cliente 418'),(927,'1419','Cliente 419'),(928,'1420','Cliente 420'),(929,'1421','Cliente 421'),(930,'1422','Cliente 422'),(931,'1423','Cliente 423'),(932,'1424','Cliente 424'),(933,'1425','Cliente 425'),(934,'1426','Cliente 426'),(935,'1427','Cliente 427'),(936,'1428','Cliente 428'),(937,'1429','Cliente 429'),(938,'1430','Cliente 430'),(939,'1431','Cliente 431'),(940,'1432','Cliente 432'),(941,'1433','Cliente 433'),(942,'1434','Cliente 434'),(943,'1435','Cliente 435'),(944,'1436','Cliente 436'),(945,'1437','Cliente 437'),(946,'1438','Cliente 438'),(947,'1439','Cliente 439'),(948,'1440','Cliente 440'),(949,'1441','Cliente 441'),(950,'1442','Cliente 442'),(951,'1443','Cliente 443'),(952,'1444','Cliente 444'),(953,'1445','Cliente 445'),(954,'1446','Cliente 446'),(955,'1447','Cliente 447'),(956,'1448','Cliente 448'),(957,'1449','Cliente 449'),(958,'1450','Cliente 450'),(959,'1451','Cliente 451'),(960,'1452','Cliente 452'),(961,'1453','Cliente 453'),(962,'1454','Cliente 454'),(963,'1455','Cliente 455'),(964,'1456','Cliente 456'),(965,'1457','Cliente 457'),(966,'1458','Cliente 458'),(967,'1459','Cliente 459'),(968,'1460','Cliente 460'),(969,'1461','Cliente 461'),(970,'1462','Cliente 462'),(971,'1463','Cliente 463'),(972,'1464','Cliente 464'),(973,'1465','Cliente 465'),(974,'1466','Cliente 466'),(975,'1467','Cliente 467'),(976,'1468','Cliente 468'),(977,'1469','Cliente 469'),(978,'1470','Cliente 470'),(979,'1471','Cliente 471'),(980,'1472','Cliente 472'),(981,'1473','Cliente 473'),(982,'1474','Cliente 474'),(983,'1475','Cliente 475'),(984,'1476','Cliente 476'),(985,'1477','Cliente 477'),(986,'1478','Cliente 478'),(987,'1479','Cliente 479'),(988,'1480','Cliente 480'),(989,'1481','Cliente 481'),(990,'1482','Cliente 482'),(991,'1483','Cliente 483'),(992,'1484','Cliente 484'),(993,'1485','Cliente 485'),(994,'1486','Cliente 486'),(995,'1487','Cliente 487'),(996,'1488','Cliente 488'),(997,'1489','Cliente 489'),(998,'1490','Cliente 490'),(999,'1491','Cliente 491'),(1000,'1492','Cliente 492'),(1001,'1493','Cliente 493'),(1002,'1494','Cliente 494'),(1003,'1495','Cliente 495'),(1004,'1496','Cliente 496'),(1005,'1497','Cliente 497'),(1006,'1498','Cliente 498'),(1007,'1499','Cliente 499'),(1008,'1500','Cliente 500'),(1009,'1501','Cliente 501'),(1010,'1502','Cliente 502'),(1011,'1503','Cliente 503'),(1012,'1504','Cliente 504'),(1013,'1505','Cliente 505'),(1014,'1506','Cliente 506'),(1015,'1507','Cliente 507'),(1016,'1508','Cliente 508'),(1017,'1509','Cliente 509'),(1018,'1510','Cliente 510'),(1019,'1511','Cliente 511'),(1020,'1512','Cliente 512'),(1021,'1513','Cliente 513'),(1022,'1514','Cliente 514'),(1023,'1515','Cliente 515'),(1024,'1516','Cliente 516'),(1025,'1517','Cliente 517'),(1026,'1518','Cliente 518'),(1027,'1519','Cliente 519'),(1028,'1520','Cliente 520'),(1029,'1521','Cliente 521'),(1030,'1522','Cliente 522'),(1031,'1523','Cliente 523'),(1032,'1524','Cliente 524'),(1033,'1525','Cliente 525'),(1034,'1526','Cliente 526'),(1035,'1527','Cliente 527'),(1036,'1528','Cliente 528'),(1037,'1529','Cliente 529'),(1038,'1530','Cliente 530'),(1039,'1531','Cliente 531'),(1040,'1532','Cliente 532'),(1041,'1533','Cliente 533'),(1042,'1534','Cliente 534'),(1043,'1535','Cliente 535'),(1044,'1536','Cliente 536'),(1045,'1537','Cliente 537'),(1046,'1538','Cliente 538'),(1047,'1539','Cliente 539'),(1048,'1540','Cliente 540'),(1049,'1541','Cliente 541'),(1050,'1542','Cliente 542'),(1051,'1543','Cliente 543'),(1052,'1544','Cliente 544'),(1053,'1545','Cliente 545'),(1054,'1546','Cliente 546'),(1055,'1547','Cliente 547'),(1056,'1548','Cliente 548'),(1057,'1549','Cliente 549'),(1058,'1550','Cliente 550'),(1059,'1551','Cliente 551'),(1060,'1552','Cliente 552'),(1061,'1553','Cliente 553'),(1062,'1554','Cliente 554'),(1063,'1555','Cliente 555'),(1064,'1556','Cliente 556'),(1065,'1557','Cliente 557'),(1066,'1558','Cliente 558'),(1067,'1559','Cliente 559'),(1068,'1560','Cliente 560'),(1069,'1561','Cliente 561'),(1070,'1562','Cliente 562'),(1071,'1563','Cliente 563'),(1072,'1564','Cliente 564'),(1073,'1565','Cliente 565'),(1074,'1566','Cliente 566'),(1075,'1567','Cliente 567'),(1076,'1568','Cliente 568'),(1077,'1569','Cliente 569'),(1078,'1570','Cliente 570'),(1079,'1571','Cliente 571'),(1080,'1572','Cliente 572'),(1081,'1573','Cliente 573'),(1082,'1574','Cliente 574'),(1083,'1575','Cliente 575'),(1084,'1576','Cliente 576'),(1085,'1577','Cliente 577'),(1086,'1578','Cliente 578'),(1087,'1579','Cliente 579'),(1088,'1580','Cliente 580'),(1089,'1581','Cliente 581'),(1090,'1582','Cliente 582'),(1091,'1583','Cliente 583'),(1092,'1584','Cliente 584'),(1093,'1585','Cliente 585'),(1094,'1586','Cliente 586'),(1095,'1587','Cliente 587'),(1096,'1588','Cliente 588'),(1097,'1589','Cliente 589'),(1098,'1590','Cliente 590'),(1099,'1591','Cliente 591'),(1100,'1592','Cliente 592'),(1101,'1593','Cliente 593'),(1102,'1594','Cliente 594'),(1103,'1595','Cliente 595'),(1104,'1596','Cliente 596'),(1105,'1597','Cliente 597'),(1106,'1598','Cliente 598'),(1107,'1599','Cliente 599'),(1108,'1600','Cliente 600'),(1109,'1601','Cliente 601'),(1110,'1602','Cliente 602'),(1111,'1603','Cliente 603'),(1112,'1604','Cliente 604'),(1113,'1605','Cliente 605'),(1114,'1606','Cliente 606'),(1115,'1607','Cliente 607'),(1116,'1608','Cliente 608'),(1117,'1609','Cliente 609'),(1118,'1610','Cliente 610'),(1119,'1611','Cliente 611'),(1120,'1612','Cliente 612'),(1121,'1613','Cliente 613'),(1122,'1614','Cliente 614'),(1123,'1615','Cliente 615'),(1124,'1616','Cliente 616'),(1125,'1617','Cliente 617'),(1126,'1618','Cliente 618'),(1127,'1619','Cliente 619'),(1128,'1620','Cliente 620'),(1129,'1621','Cliente 621'),(1130,'1622','Cliente 622'),(1131,'1623','Cliente 623'),(1132,'1624','Cliente 624'),(1133,'1625','Cliente 625'),(1134,'1626','Cliente 626'),(1135,'1627','Cliente 627'),(1136,'1628','Cliente 628'),(1137,'1629','Cliente 629'),(1138,'1630','Cliente 630'),(1139,'1631','Cliente 631'),(1140,'1632','Cliente 632'),(1141,'1633','Cliente 633'),(1142,'1634','Cliente 634'),(1143,'1635','Cliente 635'),(1144,'1636','Cliente 636'),(1145,'1637','Cliente 637'),(1146,'1638','Cliente 638'),(1147,'1639','Cliente 639'),(1148,'1640','Cliente 640'),(1149,'1641','Cliente 641'),(1150,'1642','Cliente 642'),(1151,'1643','Cliente 643'),(1152,'1644','Cliente 644'),(1153,'1645','Cliente 645'),(1154,'1646','Cliente 646'),(1155,'1647','Cliente 647'),(1156,'1648','Cliente 648'),(1157,'1649','Cliente 649'),(1158,'1650','Cliente 650'),(1159,'1651','Cliente 651'),(1160,'1652','Cliente 652'),(1161,'1653','Cliente 653'),(1162,'1654','Cliente 654'),(1163,'1655','Cliente 655'),(1164,'1656','Cliente 656'),(1165,'1657','Cliente 657'),(1166,'1658','Cliente 658'),(1167,'1659','Cliente 659'),(1168,'1660','Cliente 660'),(1169,'1661','Cliente 661'),(1170,'1662','Cliente 662'),(1171,'1663','Cliente 663'),(1172,'1664','Cliente 664'),(1173,'1665','Cliente 665'),(1174,'1666','Cliente 666'),(1175,'1667','Cliente 667'),(1176,'1668','Cliente 668'),(1177,'1669','Cliente 669'),(1178,'1670','Cliente 670'),(1179,'1671','Cliente 671'),(1180,'1672','Cliente 672'),(1181,'1673','Cliente 673'),(1182,'1674','Cliente 674'),(1183,'1675','Cliente 675'),(1184,'1676','Cliente 676'),(1185,'1677','Cliente 677'),(1186,'1678','Cliente 678'),(1187,'1679','Cliente 679'),(1188,'1680','Cliente 680'),(1189,'1681','Cliente 681'),(1190,'1682','Cliente 682'),(1191,'1683','Cliente 683'),(1192,'1684','Cliente 684'),(1193,'1685','Cliente 685'),(1194,'1686','Cliente 686'),(1195,'1687','Cliente 687'),(1196,'1688','Cliente 688'),(1197,'1689','Cliente 689'),(1198,'1690','Cliente 690'),(1199,'1691','Cliente 691'),(1200,'1692','Cliente 692'),(1201,'1693','Cliente 693'),(1202,'1694','Cliente 694'),(1203,'1695','Cliente 695'),(1204,'1696','Cliente 696'),(1205,'1697','Cliente 697'),(1206,'1698','Cliente 698'),(1207,'1699','Cliente 699'),(1208,'1700','Cliente 700'),(1209,'1701','Cliente 701'),(1210,'1702','Cliente 702'),(1211,'1703','Cliente 703'),(1212,'1704','Cliente 704'),(1213,'1705','Cliente 705'),(1214,'1706','Cliente 706'),(1215,'1707','Cliente 707'),(1216,'1708','Cliente 708'),(1217,'1709','Cliente 709'),(1218,'1710','Cliente 710'),(1219,'1711','Cliente 711'),(1220,'1712','Cliente 712'),(1221,'1713','Cliente 713'),(1222,'1714','Cliente 714'),(1223,'1715','Cliente 715'),(1224,'1716','Cliente 716'),(1225,'1717','Cliente 717'),(1226,'1718','Cliente 718'),(1227,'1719','Cliente 719'),(1228,'1720','Cliente 720'),(1229,'1721','Cliente 721'),(1230,'1722','Cliente 722'),(1231,'1723','Cliente 723'),(1232,'1724','Cliente 724'),(1233,'1725','Cliente 725'),(1234,'1726','Cliente 726'),(1235,'1727','Cliente 727'),(1236,'1728','Cliente 728'),(1237,'1729','Cliente 729'),(1238,'1730','Cliente 730'),(1239,'1731','Cliente 731'),(1240,'1732','Cliente 732'),(1241,'1733','Cliente 733'),(1242,'1734','Cliente 734'),(1243,'1735','Cliente 735'),(1244,'1736','Cliente 736'),(1245,'1737','Cliente 737'),(1246,'1738','Cliente 738'),(1247,'1739','Cliente 739'),(1248,'1740','Cliente 740'),(1249,'1741','Cliente 741'),(1250,'1742','Cliente 742'),(1251,'1743','Cliente 743'),(1252,'1744','Cliente 744'),(1253,'1745','Cliente 745'),(1254,'1746','Cliente 746'),(1255,'1747','Cliente 747'),(1256,'1748','Cliente 748'),(1257,'1749','Cliente 749'),(1258,'1750','Cliente 750'),(1259,'1751','Cliente 751'),(1260,'1752','Cliente 752'),(1261,'1753','Cliente 753'),(1262,'1754','Cliente 754'),(1263,'1755','Cliente 755'),(1264,'1756','Cliente 756'),(1265,'1757','Cliente 757'),(1266,'1758','Cliente 758'),(1267,'1759','Cliente 759'),(1268,'1760','Cliente 760'),(1269,'1761','Cliente 761'),(1270,'1762','Cliente 762'),(1271,'1763','Cliente 763'),(1272,'1764','Cliente 764'),(1273,'1765','Cliente 765'),(1274,'1766','Cliente 766'),(1275,'1767','Cliente 767'),(1276,'1768','Cliente 768'),(1277,'1769','Cliente 769'),(1278,'1770','Cliente 770'),(1279,'1771','Cliente 771'),(1280,'1772','Cliente 772'),(1281,'1773','Cliente 773'),(1282,'1774','Cliente 774'),(1283,'1775','Cliente 775'),(1284,'1776','Cliente 776'),(1285,'1777','Cliente 777'),(1286,'1778','Cliente 778'),(1287,'1779','Cliente 779'),(1288,'1780','Cliente 780'),(1289,'1781','Cliente 781'),(1290,'1782','Cliente 782'),(1291,'1783','Cliente 783'),(1292,'1784','Cliente 784'),(1293,'1785','Cliente 785'),(1294,'1786','Cliente 786'),(1295,'1787','Cliente 787'),(1296,'1788','Cliente 788'),(1297,'1789','Cliente 789'),(1298,'1790','Cliente 790'),(1299,'1791','Cliente 791'),(1300,'1792','Cliente 792'),(1301,'1793','Cliente 793'),(1302,'1794','Cliente 794'),(1303,'1795','Cliente 795'),(1304,'1796','Cliente 796'),(1305,'1797','Cliente 797'),(1306,'1798','Cliente 798'),(1307,'1799','Cliente 799'),(1308,'1800','Cliente 800'),(1309,'1801','Cliente 801'),(1310,'1802','Cliente 802'),(1311,'1803','Cliente 803'),(1312,'1804','Cliente 804'),(1313,'1805','Cliente 805'),(1314,'1806','Cliente 806'),(1315,'1807','Cliente 807'),(1316,'1808','Cliente 808'),(1317,'1809','Cliente 809'),(1318,'1810','Cliente 810'),(1319,'1811','Cliente 811'),(1320,'1812','Cliente 812'),(1321,'1813','Cliente 813'),(1322,'1814','Cliente 814'),(1323,'1815','Cliente 815'),(1324,'1816','Cliente 816'),(1325,'1817','Cliente 817'),(1326,'1818','Cliente 818'),(1327,'1819','Cliente 819'),(1328,'1820','Cliente 820'),(1329,'1821','Cliente 821'),(1330,'1822','Cliente 822'),(1331,'1823','Cliente 823'),(1332,'1824','Cliente 824'),(1333,'1825','Cliente 825'),(1334,'1826','Cliente 826'),(1335,'1827','Cliente 827'),(1336,'1828','Cliente 828'),(1337,'1829','Cliente 829'),(1338,'1830','Cliente 830'),(1339,'1831','Cliente 831'),(1340,'1832','Cliente 832'),(1341,'1833','Cliente 833'),(1342,'1834','Cliente 834'),(1343,'1835','Cliente 835'),(1344,'1836','Cliente 836'),(1345,'1837','Cliente 837'),(1346,'1838','Cliente 838'),(1347,'1839','Cliente 839'),(1348,'1840','Cliente 840'),(1349,'1841','Cliente 841'),(1350,'1842','Cliente 842'),(1351,'1843','Cliente 843'),(1352,'1844','Cliente 844'),(1353,'1845','Cliente 845'),(1354,'1846','Cliente 846'),(1355,'1847','Cliente 847'),(1356,'1848','Cliente 848'),(1357,'1849','Cliente 849'),(1358,'1850','Cliente 850'),(1359,'1851','Cliente 851'),(1360,'1852','Cliente 852'),(1361,'1853','Cliente 853'),(1362,'1854','Cliente 854'),(1363,'1855','Cliente 855'),(1364,'1856','Cliente 856'),(1365,'1857','Cliente 857'),(1366,'1858','Cliente 858'),(1367,'1859','Cliente 859'),(1368,'1860','Cliente 860'),(1369,'1861','Cliente 861'),(1370,'1862','Cliente 862'),(1371,'1863','Cliente 863'),(1372,'1864','Cliente 864'),(1373,'1865','Cliente 865'),(1374,'1866','Cliente 866'),(1375,'1867','Cliente 867'),(1376,'1868','Cliente 868'),(1377,'1869','Cliente 869'),(1378,'1870','Cliente 870'),(1379,'1871','Cliente 871'),(1380,'1872','Cliente 872'),(1381,'1873','Cliente 873'),(1382,'1874','Cliente 874'),(1383,'1875','Cliente 875'),(1384,'1876','Cliente 876'),(1385,'1877','Cliente 877'),(1386,'1878','Cliente 878'),(1387,'1879','Cliente 879'),(1388,'1880','Cliente 880'),(1389,'1881','Cliente 881'),(1390,'1882','Cliente 882'),(1391,'1883','Cliente 883'),(1392,'1884','Cliente 884'),(1393,'1885','Cliente 885'),(1394,'1886','Cliente 886'),(1395,'1887','Cliente 887'),(1396,'1888','Cliente 888'),(1397,'1889','Cliente 889'),(1398,'1890','Cliente 890'),(1399,'1891','Cliente 891'),(1400,'1892','Cliente 892'),(1401,'1893','Cliente 893'),(1402,'1894','Cliente 894'),(1403,'1895','Cliente 895'),(1404,'1896','Cliente 896'),(1405,'1897','Cliente 897'),(1406,'1898','Cliente 898'),(1407,'1899','Cliente 899'),(1408,'1900','Cliente 900'),(1409,'1901','Cliente 901'),(1410,'1902','Cliente 902'),(1411,'1903','Cliente 903'),(1412,'1904','Cliente 904'),(1413,'1905','Cliente 905'),(1414,'1906','Cliente 906'),(1415,'1907','Cliente 907'),(1416,'1908','Cliente 908'),(1417,'1909','Cliente 909'),(1418,'1910','Cliente 910'),(1419,'1911','Cliente 911'),(1420,'1912','Cliente 912'),(1421,'1913','Cliente 913'),(1422,'1914','Cliente 914'),(1423,'1915','Cliente 915'),(1424,'1916','Cliente 916'),(1425,'1917','Cliente 917'),(1426,'1918','Cliente 918'),(1427,'1919','Cliente 919'),(1428,'1920','Cliente 920'),(1429,'1921','Cliente 921'),(1430,'1922','Cliente 922'),(1431,'1923','Cliente 923'),(1432,'1924','Cliente 924'),(1433,'1925','Cliente 925'),(1434,'1926','Cliente 926'),(1435,'1927','Cliente 927'),(1436,'1928','Cliente 928'),(1437,'1929','Cliente 929'),(1438,'1930','Cliente 930'),(1439,'1931','Cliente 931'),(1440,'1932','Cliente 932'),(1441,'1933','Cliente 933'),(1442,'1934','Cliente 934'),(1443,'1935','Cliente 935'),(1444,'1936','Cliente 936'),(1445,'1937','Cliente 937'),(1446,'1938','Cliente 938'),(1447,'1939','Cliente 939'),(1448,'1940','Cliente 940'),(1449,'1941','Cliente 941'),(1450,'1942','Cliente 942'),(1451,'1943','Cliente 943'),(1452,'1944','Cliente 944'),(1453,'1945','Cliente 945'),(1454,'1946','Cliente 946'),(1455,'1947','Cliente 947'),(1456,'1948','Cliente 948'),(1457,'1949','Cliente 949'),(1458,'1950','Cliente 950'),(1459,'1951','Cliente 951'),(1460,'1952','Cliente 952'),(1461,'1953','Cliente 953'),(1462,'1954','Cliente 954'),(1463,'1955','Cliente 955'),(1464,'1956','Cliente 956'),(1465,'1957','Cliente 957'),(1466,'1958','Cliente 958'),(1467,'1959','Cliente 959'),(1468,'1960','Cliente 960'),(1469,'1961','Cliente 961'),(1470,'1962','Cliente 962'),(1471,'1963','Cliente 963'),(1472,'1964','Cliente 964'),(1473,'1965','Cliente 965'),(1474,'1966','Cliente 966'),(1475,'1967','Cliente 967'),(1476,'1968','Cliente 968'),(1477,'1969','Cliente 969'),(1478,'1970','Cliente 970'),(1479,'1971','Cliente 971'),(1480,'1972','Cliente 972'),(1481,'1973','Cliente 973'),(1482,'1974','Cliente 974'),(1483,'1975','Cliente 975'),(1484,'1976','Cliente 976'),(1485,'1977','Cliente 977'),(1486,'1978','Cliente 978'),(1487,'1979','Cliente 979'),(1488,'1980','Cliente 980'),(1489,'1981','Cliente 981'),(1490,'1982','Cliente 982'),(1491,'1983','Cliente 983'),(1492,'1984','Cliente 984'),(1493,'1985','Cliente 985'),(1494,'1986','Cliente 986'),(1495,'1987','Cliente 987'),(1496,'1988','Cliente 988'),(1497,'1989','Cliente 989'),(1498,'1990','Cliente 990'),(1499,'1991','Cliente 991'),(1500,'1992','Cliente 992'),(1501,'1993','Cliente 993'),(1502,'1994','Cliente 994'),(1503,'1995','Cliente 995'),(1504,'1996','Cliente 996'),(1505,'1997','Cliente 997'),(1506,'1998','Cliente 998'),(1507,'1999','Cliente 999'),(1508,'2000','Cliente 1000'),(1509,'2001','Cliente 1001'),(1510,'2002','Cliente 1002'),(1511,'2003','Cliente 1003'),(1512,'2004','Cliente 1004'),(1513,'2005','Cliente 1005'),(1514,'2006','Cliente 1006'),(1515,'2007','Cliente 1007'),(1516,'2008','Cliente 1008'),(1517,'2009','Cliente 1009'),(1518,'2010','Cliente 1010'),(1519,'2011','Cliente 1011'),(1520,'2012','Cliente 1012'),(1521,'2013','Cliente 1013'),(1522,'2014','Cliente 1014'),(1523,'2015','Cliente 1015'),(1524,'2016','Cliente 1016'),(1525,'2017','Cliente 1017'),(1526,'2018','Cliente 1018'),(1527,'2019','Cliente 1019'),(1528,'2020','Cliente 1020'),(1529,'2021','Cliente 1021'),(1530,'2022','Cliente 1022'),(1531,'2023','Cliente 1023'),(1532,'2024','Cliente 1024'),(1533,'2025','Cliente 1025'),(1534,'2026','Cliente 1026'),(1535,'2027','Cliente 1027'),(1536,'2028','Cliente 1028'),(1537,'2029','Cliente 1029'),(1538,'2030','Cliente 1030'),(1539,'2031','Cliente 1031'),(1540,'2032','Cliente 1032'),(1541,'2033','Cliente 1033'),(1542,'2034','Cliente 1034'),(1543,'2035','Cliente 1035'),(1544,'2036','Cliente 1036'),(1545,'2037','Cliente 1037'),(1546,'2038','Cliente 1038'),(1547,'2039','Cliente 1039'),(1548,'2040','Cliente 1040'),(1549,'2041','Cliente 1041'),(1550,'2042','Cliente 1042'),(1551,'2043','Cliente 1043'),(1552,'2044','Cliente 1044'),(1553,'2045','Cliente 1045'),(1554,'2046','Cliente 1046'),(1555,'2047','Cliente 1047'),(1556,'2048','Cliente 1048'),(1557,'2049','Cliente 1049'),(1558,'2050','Cliente 1050'),(1559,'2051','Cliente 1051'),(1560,'2052','Cliente 1052'),(1561,'2053','Cliente 1053'),(1562,'2054','Cliente 1054'),(1563,'2055','Cliente 1055'),(1564,'2056','Cliente 1056'),(1565,'2057','Cliente 1057'),(1566,'2058','Cliente 1058'),(1567,'2059','Cliente 1059'),(1568,'2060','Cliente 1060'),(1569,'2061','Cliente 1061'),(1570,'2062','Cliente 1062'),(1571,'2063','Cliente 1063'),(1572,'2064','Cliente 1064'),(1573,'2065','Cliente 1065'),(1574,'2066','Cliente 1066'),(1575,'2067','Cliente 1067'),(1576,'2068','Cliente 1068'),(1577,'2069','Cliente 1069'),(1578,'2070','Cliente 1070'),(1579,'2071','Cliente 1071'),(1580,'2072','Cliente 1072'),(1581,'2073','Cliente 1073'),(1582,'2074','Cliente 1074'),(1583,'2075','Cliente 1075'),(1584,'2076','Cliente 1076'),(1585,'2077','Cliente 1077'),(1586,'2078','Cliente 1078'),(1587,'2079','Cliente 1079'),(1588,'2080','Cliente 1080'),(1589,'2081','Cliente 1081'),(1590,'2082','Cliente 1082'),(1591,'2083','Cliente 1083'),(1592,'2084','Cliente 1084'),(1593,'2085','Cliente 1085'),(1594,'2086','Cliente 1086'),(1595,'2087','Cliente 1087'),(1596,'2088','Cliente 1088'),(1597,'2089','Cliente 1089'),(1598,'2090','Cliente 1090'),(1599,'2091','Cliente 1091'),(1600,'2092','Cliente 1092'),(1601,'2093','Cliente 1093'),(1602,'2094','Cliente 1094'),(1603,'2095','Cliente 1095'),(1604,'2096','Cliente 1096'),(1605,'2097','Cliente 1097'),(1606,'2098','Cliente 1098'),(1607,'2099','Cliente 1099'),(1608,'2100','Cliente 1100'),(1609,'2101','Cliente 1101'),(1610,'2102','Cliente 1102'),(1611,'2103','Cliente 1103'),(1612,'2104','Cliente 1104'),(1613,'2105','Cliente 1105'),(1614,'2106','Cliente 1106'),(1615,'2107','Cliente 1107'),(1616,'2108','Cliente 1108'),(1617,'2109','Cliente 1109'),(1618,'2110','Cliente 1110'),(1619,'2111','Cliente 1111'),(1620,'2112','Cliente 1112'),(1621,'2113','Cliente 1113'),(1622,'2114','Cliente 1114'),(1623,'2115','Cliente 1115'),(1624,'2116','Cliente 1116'),(1625,'2117','Cliente 1117'),(1626,'2118','Cliente 1118'),(1627,'2119','Cliente 1119'),(1628,'2120','Cliente 1120'),(1629,'2121','Cliente 1121'),(1630,'2122','Cliente 1122'),(1631,'2123','Cliente 1123'),(1632,'2124','Cliente 1124'),(1633,'2125','Cliente 1125'),(1634,'2126','Cliente 1126'),(1635,'2127','Cliente 1127'),(1636,'2128','Cliente 1128'),(1637,'2129','Cliente 1129'),(1638,'2130','Cliente 1130'),(1639,'2131','Cliente 1131'),(1640,'2132','Cliente 1132'),(1641,'2133','Cliente 1133'),(1642,'2134','Cliente 1134'),(1643,'2135','Cliente 1135'),(1644,'2136','Cliente 1136'),(1645,'2137','Cliente 1137'),(1646,'2138','Cliente 1138'),(1647,'2139','Cliente 1139'),(1648,'2140','Cliente 1140'),(1649,'2141','Cliente 1141'),(1650,'2142','Cliente 1142'),(1651,'2143','Cliente 1143'),(1652,'2144','Cliente 1144'),(1653,'2145','Cliente 1145'),(1654,'2146','Cliente 1146'),(1655,'2147','Cliente 1147'),(1656,'2148','Cliente 1148'),(1657,'2149','Cliente 1149'),(1658,'2150','Cliente 1150'),(1659,'2151','Cliente 1151'),(1660,'2152','Cliente 1152'),(1661,'2153','Cliente 1153'),(1662,'2154','Cliente 1154'),(1663,'2155','Cliente 1155'),(1664,'2156','Cliente 1156'),(1665,'2157','Cliente 1157'),(1666,'2158','Cliente 1158'),(1667,'2159','Cliente 1159'),(1668,'2160','Cliente 1160'),(1669,'2161','Cliente 1161'),(1670,'2162','Cliente 1162'),(1671,'2163','Cliente 1163'),(1672,'2164','Cliente 1164'),(1673,'2165','Cliente 1165'),(1674,'2166','Cliente 1166'),(1675,'2167','Cliente 1167'),(1676,'2168','Cliente 1168'),(1677,'2169','Cliente 1169'),(1678,'2170','Cliente 1170'),(1679,'2171','Cliente 1171'),(1680,'2172','Cliente 1172'),(1681,'2173','Cliente 1173'),(1682,'2174','Cliente 1174'),(1683,'2175','Cliente 1175'),(1684,'2176','Cliente 1176'),(1685,'2177','Cliente 1177'),(1686,'2178','Cliente 1178'),(1687,'2179','Cliente 1179'),(1688,'2180','Cliente 1180'),(1689,'2181','Cliente 1181'),(1690,'2182','Cliente 1182'),(1691,'2183','Cliente 1183'),(1692,'2184','Cliente 1184'),(1693,'2185','Cliente 1185'),(1694,'2186','Cliente 1186'),(1695,'2187','Cliente 1187'),(1696,'2188','Cliente 1188'),(1697,'2189','Cliente 1189'),(1698,'2190','Cliente 1190'),(1699,'2191','Cliente 1191'),(1700,'2192','Cliente 1192'),(1701,'2193','Cliente 1193'),(1702,'2194','Cliente 1194'),(1703,'2195','Cliente 1195'),(1704,'2196','Cliente 1196'),(1705,'2197','Cliente 1197'),(1706,'2198','Cliente 1198'),(1707,'2199','Cliente 1199'),(1708,'2200','Cliente 1200'),(1709,'2201','Cliente 1201'),(1710,'2202','Cliente 1202'),(1711,'2203','Cliente 1203'),(1712,'2204','Cliente 1204'),(1713,'2205','Cliente 1205'),(1714,'2206','Cliente 1206'),(1715,'2207','Cliente 1207'),(1716,'2208','Cliente 1208'),(1717,'2209','Cliente 1209'),(1718,'2210','Cliente 1210'),(1719,'2211','Cliente 1211'),(1720,'2212','Cliente 1212'),(1721,'2213','Cliente 1213'),(1722,'2214','Cliente 1214'),(1723,'2215','Cliente 1215'),(1724,'2216','Cliente 1216'),(1725,'2217','Cliente 1217'),(1726,'2218','Cliente 1218'),(1727,'2219','Cliente 1219'),(1728,'111','clieten111'),(1729,'222','cliente222');
/*!40000 ALTER TABLE `tbl_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_comercial`
--

DROP TABLE IF EXISTS `tbl_comercial`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_comercial` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `ID_Cliente` bigint(20) DEFAULT NULL,
  `ID_Productor` bigint(20) DEFAULT NULL,
  `ID_Especie` bigint(20) DEFAULT NULL,
  `ID_Tipo` bigint(20) DEFAULT NULL,
  `Total_Pallet` int(11) DEFAULT NULL,
  `ID_Bandeja` bigint(20) DEFAULT NULL,
  `ID_Pallet` bigint(20) DEFAULT NULL,
  `kilos_Brutos` decimal(10,3) DEFAULT NULL,
  `tara` decimal(10,3) DEFAULT NULL,
  `kilos_netos` decimal(10,3) DEFAULT NULL,
  `cantidad_bandejas` int(11) DEFAULT NULL,
  `folio` varchar(50) DEFAULT NULL,
  `fecha` varchar(30) DEFAULT NULL,
  `fecha_sistema` datetime DEFAULT CURRENT_TIMESTAMP,
  `estado` varchar(10) DEFAULT '0',
  `Maquila` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_comercial`
--

LOCK TABLES `tbl_comercial` WRITE;
/*!40000 ALTER TABLE `tbl_comercial` DISABLE KEYS */;
INSERT INTO `tbl_comercial` VALUES (1,6,1,1,1,100,1,1,1000.000,100.000,900.000,50,'GQ123','2018-12-24T19:12:13',NULL,'1','35'),(2,6,1,1,2,100,1,1,1000.000,50.000,950.000,50,'GS123','2018-12-24T19:14:37',NULL,'1','35'),(3,6,1,1,1,100,1,1,100.000,NULL,NULL,10,'FC0044','2018-12-27T01:30:39',NULL,'0',NULL),(4,6,1,2,1,10,1,1,121.000,21.160,99.840,10,'11','2019-01-03T13:31:44',NULL,'1','35'),(5,6,1,2,1,10,2,1,122.000,24.060,97.940,11,'22','2019-01-03T13:32:42',NULL,'1','35'),(6,6,2,6,2,10,1,1,1211.000,75.160,1135.840,40,'FC11','2019-01-04T00:14:08',NULL,'0','24'),(7,6,1,6,1,2,1,1,100.000,21.160,78.840,10,'fcgt555','2019-01-05T01:20:35',NULL,'1','38'),(8,6,1,6,1,2,1,1,322.000,93.160,228.840,50,'fcg555','2019-01-05T01:20:51',NULL,'1','39'),(9,6,1,6,1,2,2,1,422.000,234.960,187.040,122,'de333','2019-01-05T01:21:05',NULL,'1','37'),(10,6,1,6,2,2,1,1,121.000,222.760,-101.760,122,'121','2019-01-05T01:21:54',NULL,'1','36'),(11,6,1,6,2,1211,1,1,1233.000,22162.960,-20929.960,12311,'gff','2019-01-05T01:30:08',NULL,'0','24'),(12,6,2,6,1,10,1,1,10011.000,21.160,9989.840,10,'Fc001','2019-01-08T12:53:12',NULL,'0',NULL),(13,7,4,2,1,10,1,1,123.330,21.160,102.170,10,'33','2019-01-08T13:02:09',NULL,'0',NULL),(14,6,1,6,1,3,2,1,123.340,193.160,-69.820,100,'FC786','2019-01-09T12:04:40','2019-01-09 12:04:40','0',NULL),(15,6,1,6,1,3,1,1,222.200,219.160,3.040,120,'FC6544','2019-01-09T12:05:38','2019-01-09 12:05:38','1','35'),(16,6,1,6,1,12,1,2,12231.000,226.100,12004.900,123,'FC655','2019-01-09T15:41:06','2019-01-09 15:41:06','0',NULL),(17,6,1,6,1,12,1,1,123.000,224.560,-101.560,123,'fc003','2019-01-09T15:41:26','2019-01-09 15:41:26','0',NULL);
/*!40000 ALTER TABLE `tbl_comercial` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_correlativo`
--

DROP TABLE IF EXISTS `tbl_correlativo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_correlativo` (
  `Proceso` varchar(50) NOT NULL,
  `SubProceso` varchar(50) NOT NULL,
  `correlativo_disponible` bigint(20) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_correlativo`
--

LOCK TABLES `tbl_correlativo` WRITE;
/*!40000 ALTER TABLE `tbl_correlativo` DISABLE KEYS */;
INSERT INTO `tbl_correlativo` VALUES ('Recepcion','Recepcion',29);
/*!40000 ALTER TABLE `tbl_correlativo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_destinorecepcion`
--

DROP TABLE IF EXISTS `tbl_destinorecepcion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_destinorecepcion` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_destinorecepcion`
--

LOCK TABLES `tbl_destinorecepcion` WRITE;
/*!40000 ALTER TABLE `tbl_destinorecepcion` DISABLE KEYS */;
INSERT INTO `tbl_destinorecepcion` VALUES (1,'Packing'),(2,'Congelado');
/*!40000 ALTER TABLE `tbl_destinorecepcion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_embalaje`
--

DROP TABLE IF EXISTS `tbl_embalaje`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_embalaje` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50) DEFAULT NULL,
  `peso` decimal(10,3) DEFAULT NULL,
  `potes` int(11) DEFAULT NULL,
  `ID_cliente` bigint(20) NOT NULL,
  UNIQUE KEY `codigo` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_embalaje`
--

LOCK TABLES `tbl_embalaje` WRITE;
/*!40000 ALTER TABLE `tbl_embalaje` DISABLE KEYS */;
INSERT INTO `tbl_embalaje` VALUES (1,'1.1',10.000,4,6),(2,'2.2',11.000,35,7),(3,'3.3',10.000,50,6),(4,'4.4',20.000,40,7),(5,'5.5',11.000,30,6),(6,'1.1.1',12.000,13,509);
/*!40000 ALTER TABLE `tbl_embalaje` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_especie`
--

DROP TABLE IF EXISTS `tbl_especie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_especie` (
  `ID_especie` bigint(20) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(50) NOT NULL,
  `fecha_uso` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID_especie`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_especie`
--

LOCK TABLES `tbl_especie` WRITE;
/*!40000 ALTER TABLE `tbl_especie` DISABLE KEYS */;
INSERT INTO `tbl_especie` VALUES (1,'Arandano','2019-01-03 22:56:53'),(2,'Cereza','2018-12-26 17:21:19'),(3,'Melon','2018-11-19 13:46:00'),(4,'Durazno','2018-11-19 13:46:56'),(5,'Frutilla','2018-11-19 13:47:00'),(6,'Manzana','2019-01-10 16:47:17');
/*!40000 ALTER TABLE `tbl_especie` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_etiqueta`
--

DROP TABLE IF EXISTS `tbl_etiqueta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_etiqueta` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(50) DEFAULT NULL,
  `ID_especie` bigint(20) DEFAULT NULL,
  `ID_cliente` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_etiqueta`
--

LOCK TABLES `tbl_etiqueta` WRITE;
/*!40000 ALTER TABLE `tbl_etiqueta` DISABLE KEYS */;
INSERT INTO `tbl_etiqueta` VALUES (1,'Berry Fresh 1',6,6),(2,'Berry Fresh 2',2,7),(3,'Berry Fresh 3',1,6);
/*!40000 ALTER TABLE `tbl_etiqueta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_exportacion`
--

DROP TABLE IF EXISTS `tbl_exportacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_exportacion` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `ID_Cliente` bigint(20) DEFAULT NULL,
  `ID_Especie` bigint(20) DEFAULT NULL,
  `ID_Embalaje` bigint(20) DEFAULT NULL,
  `ID_Etiqueta` bigint(20) DEFAULT NULL,
  `ID_TipoArmado` bigint(20) DEFAULT NULL,
  `ID_TipoMercado` bigint(20) DEFAULT NULL,
  `Folio` varchar(50) DEFAULT NULL,
  `ID_Productor` bigint(20) DEFAULT NULL,
  `ID_Variedad` bigint(20) DEFAULT NULL,
  `fecha` varchar(50) DEFAULT NULL,
  `cantidad_cajas` bigint(20) DEFAULT NULL,
  `documento` varchar(50) DEFAULT NULL,
  `fecha_sistema` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `estado` int(11) NOT NULL DEFAULT '0',
  `Maquila` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=73 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_exportacion`
--

LOCK TABLES `tbl_exportacion` WRITE;
/*!40000 ALTER TABLE `tbl_exportacion` DISABLE KEYS */;
INSERT INTO `tbl_exportacion` VALUES (1,6,6,2,1,1,2,'FC001',1,1,'-2025',10,'1','2018-12-05 12:18:59',1,'35'),(2,6,6,2,1,1,2,'FC001',2,2,'-2025',50,'400','2018-12-05 12:19:17',0,'24'),(3,6,6,2,1,1,2,'FC001',2,2,'-2025',121,'122','2018-12-05 12:19:27',0,'24'),(4,6,6,2,1,1,1,'FC001',1,1,'-2025',10,'1001','2018-12-05 12:21:44',1,'35'),(5,6,6,2,1,1,1,'FC001',2,1,'-2025',20,'2001','2018-12-05 12:21:44',0,'24'),(6,6,6,2,1,1,1,'FC001',3,2,'-2025',30,'3001','2018-12-05 12:21:44',0,'24'),(7,6,6,2,1,1,1,'FC001',1,1,'-2025',10,'1001','2018-12-05 12:24:07',1,'35'),(8,6,6,2,1,1,1,'FC001',2,1,'-2025',20,'2001','2018-12-05 12:24:08',0,'24'),(9,6,6,2,1,1,1,'FC001',3,2,'-2025',30,'3001','2018-12-05 12:24:08',0,'24'),(10,6,6,2,1,1,1,'FC001',1,1,'-2025',10,'1001','2018-12-05 12:24:54',1,'35'),(11,6,6,2,1,1,1,'FC001',2,1,'-2025',20,'2001','2018-12-05 12:24:55',0,'24'),(12,6,6,2,1,1,1,'FC001',3,2,'-2025',30,'3001','2018-12-05 12:24:55',0,'24'),(13,6,6,1,1,1,1,'FC001',1,1,'-2025',10,'1001','2018-12-05 12:30:08',1,'35'),(14,6,6,1,1,1,1,'FC001',1,2,'-2025',20,'1002','2018-12-05 12:30:09',1,'35'),(15,6,6,1,1,1,1,'FC001',1,2,'-2025',30,'1003','2018-12-05 12:30:09',1,'35'),(16,6,6,1,1,1,1,'FC001',1,1,'-2025',10,'1001','2018-12-05 12:30:29',1,'35'),(17,6,6,1,1,1,1,'FC001',1,2,'-2025',20,'1002','2018-12-05 12:30:29',1,'35'),(18,6,6,1,1,1,1,'FC001',1,2,'-2025',30,'1003','2018-12-05 12:30:29',1,'35'),(19,6,6,1,1,1,1,'FC001',1,1,'-2025',10,'1001','2018-12-05 12:31:55',1,'35'),(20,6,6,1,1,1,1,'FC001',1,2,'-2025',20,'1002','2018-12-05 12:31:55',1,'35'),(21,6,6,1,1,1,1,'FC001',1,2,'-2025',30,'1003','2018-12-05 12:31:55',1,'35'),(22,6,6,1,1,1,1,'FC001',1,1,'-2025',11,'11','2018-12-05 12:34:08',1,'35'),(23,6,6,1,2,1,1,'1211',2,1,'-2025',1231,'112','2018-12-05 15:36:21',0,'19'),(24,6,6,1,2,1,1,'1211',2,1,'-2025',121,'122','2018-12-05 15:36:21',0,'19'),(25,6,6,1,2,1,1,'1211',2,1,'-2025',1231,'112','2018-12-05 15:38:48',0,'19'),(26,6,6,1,2,1,1,'1211',2,1,'-2025',121,'122','2018-12-05 15:38:49',0,'19'),(27,6,6,1,2,1,1,'1211',2,1,'-2025',1231,'112','2018-12-05 15:39:19',0,'19'),(28,6,6,1,2,1,1,'1211',2,1,'-2025',121,'122','2018-12-05 15:39:20',0,'19'),(29,6,6,2,1,1,1,'FC001',1,1,'-2025',100,'12','2018-12-05 15:43:33',1,'35'),(30,6,6,2,1,1,1,'FC001',1,1,'-2025',33,'21','2018-12-05 15:43:33',1,'35'),(31,6,6,2,1,1,1,'FC001',1,1,'-2025',121,'211','2018-12-05 15:43:34',1,'35'),(32,7,6,1,2,1,1,'fc005',4,1,'-2025',10212,'122','2018-12-05 15:46:44',0,'18'),(33,7,6,1,2,1,1,'fc005',4,1,'-2025',2333,'554','2018-12-05 15:46:45',0,'18'),(34,7,6,1,2,1,1,'fc005',4,1,'-2025',668,'566','2018-12-05 15:46:46',0,'18'),(35,6,6,1,1,1,2,'FC001',1,1,'-2025',30,'432','2018-12-05 15:51:12',1,'35'),(36,6,6,1,1,1,2,'FC001',1,1,'-2025',1221,'432','2018-12-05 15:51:12',1,'35'),(37,6,6,1,1,1,2,'FC001',1,1,'-2025',1211,'5454','2018-12-05 15:51:12',1,'35'),(38,6,6,1,1,1,2,'FC001',1,1,'-2025',1,'1','2018-12-05 15:51:13',1,'35'),(39,6,6,1,1,1,2,'FC001',1,1,'-2025',2,'2','2018-12-05 15:51:14',1,'35'),(40,6,6,1,1,1,2,'FC001',1,1,'-2025',3,'3','2018-12-05 15:51:15',1,'35'),(41,6,6,1,1,1,2,'FC001',1,1,'-2025',4,'4','2018-12-05 15:51:15',1,'35'),(42,6,6,1,1,1,2,'FC001',1,1,'-2025',5,'5','2018-12-05 15:51:15',1,'35'),(43,6,6,1,1,1,2,'FC001',1,1,'-2025',66,'6','2018-12-05 15:51:15',1,'35'),(44,6,6,1,1,1,2,'FC001',1,1,'-2025',7,'7','2018-12-05 15:51:15',1,'35'),(45,7,6,1,1,1,1,'FC001',4,1,'-2025',1,'1','2018-12-05 15:59:12',0,'24'),(46,7,6,1,1,1,1,'FC001',4,1,'-2025',2,'2','2018-12-05 15:59:13',0,'24'),(47,7,6,1,1,1,1,'FC001',4,1,'-2025',3,'3','2018-12-05 15:59:14',0,'24'),(48,7,6,1,1,1,1,'FC001',4,1,'-2025',4,'4','2018-12-05 15:59:14',0,'24'),(49,7,6,1,1,1,1,'FC001',4,1,'-2025',5,'5','2018-12-05 15:59:14',0,'24'),(50,7,6,1,1,1,1,'FC001',4,1,'-2025',6,'6','2018-12-05 15:59:15',0,'24'),(51,7,6,1,1,1,1,'FC001',4,1,'-2025',7,'7','2018-12-05 15:59:16',0,'24'),(52,7,6,1,1,1,1,'FC001',4,1,'-2025',8,'8','2018-12-05 15:59:16',0,'24'),(53,7,6,1,1,1,1,'FC001',4,1,'-2025',9,'9','2018-12-05 15:59:16',0,'24'),(54,7,6,1,1,1,1,'FC001',4,1,'-2025',10,'10','2018-12-05 15:59:16',0,'24'),(55,7,6,1,1,1,1,'FA001',4,1,'-2024',50,'121','2018-12-06 16:36:03',0,'16'),(56,7,6,1,1,1,1,'FA001',4,2,'-2024',30,'332','2018-12-06 16:36:03',0,'16'),(57,7,6,1,1,1,1,'FA001',4,2,'-2024',121,'2211','2018-12-06 16:36:04',0,'16'),(58,6,2,1,1,1,1,'FC9765',1,1,'-2000',30,'32','2018-12-30 01:34:58',1,'37'),(59,6,2,1,1,1,1,'FC9765',1,1,'-2000',122,'43','2018-12-30 01:34:58',1,'37'),(60,6,6,1,1,1,1,'FC002',1,1,'-2016',12,'12','2019-01-04 00:13:26',1,'35'),(61,6,6,1,1,1,1,'FC002',1,1,'-2016',33,'12','2019-01-04 00:13:26',1,'35'),(62,6,6,1,1,1,1,'fc004',2,1,'2008',12,'123','2019-01-10 11:46:42',0,NULL),(63,6,6,1,1,1,1,'fc006',2,2,'2008',1,'','2019-01-10 11:53:59',0,NULL),(64,6,6,1,1,1,1,'fc007',1,2,'2008',1,'','2019-01-10 11:54:54',1,'38'),(65,6,6,1,1,1,1,'fc007',2,2,'2008',1,'','2019-01-10 11:55:01',0,NULL),(66,6,6,1,1,1,1,'fc008',1,2,'2008',1,'','2019-01-10 11:56:01',1,'36'),(67,6,6,1,1,1,1,'fc008',2,2,'2008',1,'','2019-01-10 11:56:03',0,NULL),(68,6,6,1,1,1,1,'12123',1,1,'2010',12,'12','2019-01-10 14:58:17',1,'39'),(69,6,6,1,1,1,1,'12124',1,1,'2010',12,'12','2019-01-10 14:59:48',0,NULL),(70,6,6,1,1,1,1,'12125',1,1,'2008',12,'12','2019-01-10 15:00:09',0,NULL),(71,6,6,1,1,2,2,'123124',1,2,'10-01-2019',12,'12','2019-01-10 15:07:08',0,NULL),(72,6,6,1,1,2,2,'123125',1,2,'10-01-2019',12,'12','2019-01-10 15:10:35',0,NULL);
/*!40000 ALTER TABLE `tbl_exportacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_maquila`
--

DROP TABLE IF EXISTS `tbl_maquila`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_maquila` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `ID_Cliente` varchar(50) DEFAULT NULL,
  `ID_Productor` varchar(50) DEFAULT NULL,
  `Lote` bigint(20) DEFAULT NULL,
  `documento` varchar(50) DEFAULT NULL,
  `fecha_sistema` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `fecha_recepcion` datetime DEFAULT NULL,
  `ordenEmbalaje` varchar(50) DEFAULT NULL,
  `Linea` int(11) DEFAULT NULL,
  `hora_Inicio` varchar(50) DEFAULT NULL,
  `hora_Termino` varchar(50) DEFAULT NULL,
  `rendimiento` varchar(50) DEFAULT NULL,
  `kilos_exportacion` decimal(10,3) DEFAULT NULL,
  `kilos_comerciales` decimal(10,3) DEFAULT NULL,
  `kilos_merma` decimal(10,3) DEFAULT NULL,
  `kilos_recepcion` decimal(10,3) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=40 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_maquila`
--

LOCK TABLES `tbl_maquila` WRITE;
/*!40000 ALTER TABLE `tbl_maquila` DISABLE KEYS */;
INSERT INTO `tbl_maquila` VALUES (1,'6','1',1,'555','2018-12-29 20:13:06','2018-12-29 20:06:40','12311',6,'2018-12-29 20:06:47.666','2018-12-29 20:06:49.054','80',0.000,0.000,0.000,NULL),(2,'6','1',1,'123','2019-01-01 01:25:16','2019-01-01 01:24:16','1232',1,'2019-01-01 01:24:13.754','2019-01-01 01:24:15.051','50',0.000,0.000,0.000,NULL),(3,'6','1',1,'1231','2019-01-01 02:38:06','2019-01-01 02:37:00','5442',1,'2019-01-01 02:36:56.898','2019-01-01 02:37:04.186','99',0.000,0.000,0.000,NULL),(4,'6','1',1,'1231','2019-01-01 02:42:34','2019-01-01 02:42:12','1221',1,'2019-01-01 02:42:10.911','2019-01-01 02:42:11.288','99',0.000,0.000,0.000,NULL),(5,'6','1',1,'123','2019-01-01 02:47:34','2019-01-01 02:47:14','12',3,'2019-01-01 02:47:17.108','2019-01-01 02:47:19.228','77',0.000,0.000,0.000,NULL),(6,'6','1',1,'123','2019-01-01 02:52:56','2019-01-01 02:52:31','1231',3,'2019-01-01 02:52:37.613','2019-01-01 02:52:38.045','77',0.000,0.000,0.000,NULL),(7,'6','1',1,'1211','2019-01-02 01:06:23','2019-01-02 01:06:01','1211',1,'2019-01-02 01:05:57.271','2019-01-02 01:05:58.036','122',0.000,0.000,0.000,NULL),(8,'6','1',1,'1221','2019-01-02 01:07:47','2019-01-02 01:07:30','3221',21,'2019-01-02 01:07:25.172','2019-01-02 01:07:25.589','12',0.000,0.000,0.000,NULL),(9,'6','1',1,'1221','2019-01-02 01:09:11','2019-01-02 01:07:30','3221',21,'2019-01-02 01:07:25.172','2019-01-02 01:07:25.589','12',0.000,0.000,0.000,NULL),(10,'6','1',1,'1221','2019-01-02 01:09:37','2019-01-02 01:07:30','3221',21,'2019-01-02 01:07:25.172','2019-01-02 01:07:25.589','12',0.000,0.000,0.000,NULL),(11,'6','1',1,'1221','2019-01-02 01:10:31','2019-01-02 01:07:30','3221',21,'2019-01-02 01:07:25.172','2019-01-02 01:07:25.589','12',0.000,0.000,0.000,NULL),(12,'6','1',1,'1211','2019-01-02 22:37:06','2019-01-02 22:36:42','6655',1231,'2019-01-02 22:36:49.496','2019-01-02 22:36:50.336','65',0.000,0.000,0.000,NULL),(13,'6','1',1,'444','2019-01-02 22:42:33','2019-01-02 22:42:23','22',33,'2019-01-02 22:42:28.099','2019-01-02 22:42:28.431','12',0.000,0.000,0.000,NULL),(14,'6','1',1,'1231','2019-01-03 12:19:36','2019-01-03 12:19:25','213',12,'2019-01-03 12:18:29.664','2019-01-03 12:18:30.046','12',0.000,0.000,0.000,NULL),(15,'6','1',1,'1231','2019-01-03 12:21:55','2019-01-03 12:19:25','213',12,'2019-01-03 12:18:29.664','2019-01-03 12:18:30.046','12',0.000,0.000,0.000,NULL),(16,'6','1',1,'121','2019-01-04 00:16:14','2019-01-04 00:16:05','',2,'2019-01-04 00:16:01.510','2019-01-04 00:16:02.009','12',0.000,0.000,0.000,NULL),(17,'6','1',1,'121','2019-01-04 13:27:15','2019-01-04 13:24:47','',2,'2019-01-04 13:24:52.203','2019-01-04 00:24:52 ','12',0.000,0.000,0.000,NULL),(18,'6','1',1,'1231','2019-01-04 13:31:46','2019-01-04 13:31:29','',1,'2019-01-04 13:31:25.759','2019-01-04 13:31:26.224','10',0.000,0.000,0.000,NULL),(19,'6','1',1,'121','2019-01-06 01:51:10','2019-01-06 01:50:18','1221',3,'2019-01-06 01:50:11.077','2019-01-06 01:50:11.595','211',12410.000,900.000,950.000,103.000),(20,'6','1',1,'11','2019-01-06 01:58:32','2019-01-06 01:58:28','32',1,'2019-01-06 01:58:22.740','2019-01-06 01:58:23.258','1',100.000,900.000,950.000,100.000),(21,'6','1',1,'121','2019-01-06 02:06:37','2019-01-06 02:05:58','122',1,'2019-01-06 02:06:01.088','2019-01-06 02:06:02.245','122',100.000,900.000,950.000,100.000),(22,'6','1',1,'12','2019-01-06 02:33:41','2019-01-06 02:33:20','322',2,'2019-01-06 02:33:14.559','2019-01-06 02:33:22.822','121',100.000,900.000,950.000,100.000),(23,'6','1',1,'12','2019-01-06 02:36:48','2019-01-06 02:33:20','322',2,'2019-01-06 02:33:14.559','2019-01-06 02:33:22.822','121',100.000,1097.780,848.240,100.000),(24,'6','1',1,'12','2019-01-06 02:40:15','2019-01-06 02:33:20','322',2,'2019-01-06 02:33:14.559','2019-01-06 02:33:22.822','121',100.000,1097.780,-18945.880,100.000),(25,'6','1',1,'122','2019-01-07 11:59:08','2019-01-07 11:55:56','22',1,'2019-01-07 11:55:51.425','2019-01-07 11:55:51.967','12',100.000,0.000,950.000,75.240),(26,'6','1',1,'12','2019-01-07 12:06:01','2019-01-07 12:04:39','121',2,'2019-01-07 12:04:36.205','2019-01-07 12:04:36.655','33',100.000,900.000,950.000,75.240),(27,'6','1',1,'111','2019-01-07 12:13:40','2019-01-07 12:13:06','1211',1,'2019-01-07 12:13:11.074','2019-01-07 12:13:11.625','211',100.000,900.000,950.000,75.240),(28,'6','1',1,'11','2019-01-07 12:28:42','2019-01-07 12:27:52','32',1,'2019-01-07 12:27:55.794','2019-01-07 12:27:56.253','11',100.000,0.000,950.000,75.240),(29,'6','1',1,'1211','2019-01-07 12:41:47','2019-01-07 12:38:23','1211',1,'2019-01-07 12:38:19.161','2019-01-07 12:38:20.069','211',400.000,900.000,950.000,75.240),(30,'6','1',1,'1211','2019-01-07 12:43:26','2019-01-07 12:38:23','1211',1,'2019-01-07 12:38:19.161','2019-01-07 12:38:20.069','211',400.000,900.000,950.000,71.280),(31,'6','1',1,'12','2019-01-09 11:47:27','2019-01-09 11:47:11','1222',2,'2019-01-09 11:43:01.913','2019-01-09 11:43:02.947','12',220.000,900.000,950.000,75.240),(32,'6','1',1,'12','2019-01-09 11:49:56','2019-01-09 11:47:11','1222',2,'2019-01-09 11:43:01.913','2019-01-09 11:43:02.947','12',220.000,1097.780,848.240,59.714),(33,'6','1',1,'12','2019-01-09 11:50:48','2019-01-09 11:47:11','1222',2,'2019-01-09 11:43:01.913','2019-01-09 11:43:02.947','12',220.000,1097.780,848.240,59.714),(34,'6','1',1,'1231','2019-01-09 15:38:37','2019-01-09 15:36:02','121',2,'2019-01-09 15:38:31.327','2019-01-09 15:38:31.775','11',220.000,1100.820,950.000,66.520),(35,'6','1',1,'1231','2019-01-09 15:39:20','2019-01-09 15:36:02','121',2,'2019-01-09 15:38:31.327','2019-01-09 15:38:31.775','11',220.000,1100.820,950.000,66.520),(36,'6','1',1,'121213','2019-01-10 17:13:19','2019-01-10 17:06:31','1242',1,'2019-01-10 17:06:31.655','2019-01-10 17:06:32.229','23',10.000,0.000,-101.760,-6.806),(37,'6','1',1,'211231','2019-01-10 17:17:26','2019-01-10 17:16:23','131312',1,'2019-01-10 17:16:18.898','2019-01-10 17:16:19.279','12',300.000,187.040,0.000,-8.300),(38,'6','1',1,'1231','2019-01-10 17:23:11','2019-01-10 17:22:30','13414',1,'2019-01-10 17:22:28.985','2019-01-10 17:22:29.441','131',10.000,78.840,0.000,-7.160),(39,'6','1',1,'556','2019-01-10 17:41:06','2019-01-10 17:39:50','12',1,'2019-01-10 17:39:44.266','2019-01-10 17:39:44.751','23',120.000,228.840,0.000,-8.000);
/*!40000 ALTER TABLE `tbl_maquila` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_pallet`
--

DROP TABLE IF EXISTS `tbl_pallet`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_pallet` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(50) NOT NULL,
  `Peso` decimal(5,3) NOT NULL DEFAULT '0.000',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_pallet`
--

LOCK TABLES `tbl_pallet` WRITE;
/*!40000 ALTER TABLE `tbl_pallet` DISABLE KEYS */;
INSERT INTO `tbl_pallet` VALUES (1,'Madera',3.160),(2,'Metal',4.700),(3,'Plastico',2.077);
/*!40000 ALTER TABLE `tbl_pallet` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_productor`
--

DROP TABLE IF EXISTS `tbl_productor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_productor` (
  `codigo` bigint(20) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50) NOT NULL,
  `codigo_cliente` bigint(20) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_productor`
--

LOCK TABLES `tbl_productor` WRITE;
/*!40000 ALTER TABLE `tbl_productor` DISABLE KEYS */;
INSERT INTO `tbl_productor` VALUES (1,'Productor1',6),(2,'productor2',6),(3,'productor3',6),(4,'productor4',7),(5,'productor5',7),(6,'productor6',3),(7,'productor7',3),(8,'productor8',3),(9,'productor9',4),(10,'productor10',4);
/*!40000 ALTER TABLE `tbl_productor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_recepcion`
--

DROP TABLE IF EXISTS `tbl_recepcion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_recepcion` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `ID_cliente` bigint(20) DEFAULT NULL,
  `ID_productor` bigint(20) DEFAULT NULL,
  `chofer` varchar(50) DEFAULT NULL,
  `guia` varchar(50) DEFAULT NULL,
  `ID_especie` bigint(20) DEFAULT NULL,
  `ID_descarga` bigint(20) DEFAULT NULL,
  `temperatura` decimal(10,3) DEFAULT NULL,
  `ID_destino` bigint(20) DEFAULT NULL,
  `fecha` datetime DEFAULT NULL,
  `fecha_sistema` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `lote` bigint(20) DEFAULT NULL,
  `estado` int(11) NOT NULL DEFAULT '0',
  `cantidad_pallets` bigint(20) NOT NULL,
  `ID_tipo` bigint(20) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_recepcion`
--

LOCK TABLES `tbl_recepcion` WRITE;
/*!40000 ALTER TABLE `tbl_recepcion` DISABLE KEYS */;
INSERT INTO `tbl_recepcion` VALUES (1,6,1,'Fulano','1122',1,1,1.000,2,'2019-01-03 16:36:18','2019-01-03 16:37:22',12,0,3,0),(2,6,1,'Fulano','1122',1,1,1.000,1,'2019-01-03 16:49:41','2019-01-03 16:50:02',13,0,3,0),(3,6,1,'huttt','655',1,1,-87.000,1,'2019-01-03 22:49:15','2019-01-03 22:49:23',14,0,10,0),(4,6,1,'hu','5433',6,1,-55.000,1,'2019-01-03 23:24:17','2019-01-03 23:24:20',15,0,100,0),(5,6,1,'121','123',6,1,-122.000,1,'2019-01-04 00:12:37','2019-01-04 00:12:40',16,0,10,0),(6,6,1,'fulano','1231',6,1,1231.000,1,'2019-01-04 12:04:40','2019-01-04 12:04:41',17,0,10,0),(7,6,1,'12311','12311',6,1,12.000,1,'2019-01-05 01:36:00','2019-01-05 01:36:01',18,0,120,0),(8,6,1,'fulano','33',1,1,22.220,1,'2019-01-07 17:36:08','2019-01-07 17:36:09',19,0,11,0),(9,6,1,'fulano','22',6,1,12.000,2,'2019-01-07 17:41:04','2019-01-07 17:41:05',20,0,333,0),(10,6,1,'Fulanito','121241223',6,1,1.000,1,'2019-01-09 17:08:36','2019-01-09 17:08:36',24,0,12,0),(11,6,1,'Fulano de tal','1123',6,1,-2.500,1,'2019-01-10 15:54:22','2019-01-10 15:55:15',26,0,3,1),(12,6,1,'FF','1123',6,1,-2.500,1,'2019-01-10 16:05:44','2019-01-10 16:06:35',27,0,3,1),(13,7,4,'Fulano de tal','1124',6,1,-2.500,1,'2019-01-10 16:45:55','2019-01-10 16:46:08',28,0,3,1);
/*!40000 ALTER TABLE `tbl_recepcion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_recepcion_detalle`
--

DROP TABLE IF EXISTS `tbl_recepcion_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_recepcion_detalle` (
  `ID_Recepcion` bigint(20) DEFAULT NULL,
  `item` bigint(20) DEFAULT NULL,
  `ID_Bandeja` bigint(20) DEFAULT NULL,
  `bandeja` varchar(50) DEFAULT NULL,
  `peso_bandeja` decimal(5,0) DEFAULT NULL,
  `cantidad_bandejas` bigint(20) DEFAULT NULL,
  `folio` varchar(50) DEFAULT NULL,
  `kilos_brutos_original` decimal(10,3) DEFAULT NULL,
  `kilos_brutos` decimal(10,3) DEFAULT NULL,
  `tara` decimal(10,3) DEFAULT NULL,
  `kilos_netos` decimal(10,3) DEFAULT NULL,
  `ID_pallet` bigint(20) DEFAULT NULL,
  `tipo_pallet` varchar(50) DEFAULT NULL,
  `peso_pallet` decimal(5,0) DEFAULT NULL,
  `fecha` datetime DEFAULT CURRENT_TIMESTAMP,
  `estado` int(11) NOT NULL DEFAULT '0',
  `Maquila` varchar(50) DEFAULT NULL,
  `posicion` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_recepcion_detalle`
--

LOCK TABLES `tbl_recepcion_detalle` WRITE;
/*!40000 ALTER TABLE `tbl_recepcion_detalle` DISABLE KEYS */;
INSERT INTO `tbl_recepcion_detalle` VALUES (1,1,1,'Torito',2,1,'1',NULL,1.000,4.960,-3.960,1,'Madera',3,'2019-01-03 16:37:38',1,'35',1),(1,2,1,'Torito',2,2,'2',NULL,2.000,6.760,-4.760,1,'Madera',3,'2019-01-03 16:41:33',1,'35',2),(1,3,3,'Verde',2,3,'3',NULL,3.000,9.806,-6.806,2,'Metal',5,'2019-01-03 16:46:52',1,'36',3),(2,1,2,'Blanco/Amarillo',2,4,'4',NULL,4.000,12.300,-8.300,2,'Metal',5,'2019-01-03 16:50:21',1,'37',1),(2,2,1,'Torito',2,5,'5',NULL,5.000,12.160,-7.160,1,'Madera',3,'2019-01-03 16:51:30',1,'38',2),(2,3,5,'Rojo',2,6,'6',NULL,6.000,14.000,-8.000,2,'Metal',5,'2019-01-03 16:52:07',1,'39',3),(3,1,2,'Blanco/Amarillo',2,4,'FC4332',NULL,122.000,10.760,111.240,1,'Madera',3,'2019-01-03 22:49:23',0,NULL,1),(3,2,2,'Blanco/Amarillo',2,50,'FC776',NULL,300.000,98.160,201.840,1,'Madera',3,'2019-01-03 22:50:19',0,NULL,2),(3,3,1,'Torito',2,10,'FC55433',NULL,700.000,21.160,678.840,1,'Madera',3,'2019-01-03 22:52:36',0,NULL,3),(3,4,1,'Torito',2,55,'888',NULL,766.000,102.160,663.840,1,'Madera',3,'2019-01-03 22:53:40',0,NULL,4),(3,5,1,'Torito',2,10,'fc5444',NULL,7888.000,21.160,7866.840,1,'Madera',3,'2019-01-03 22:54:45',0,NULL,5),(3,6,2,'Blanco/Amarillo',2,1121,'122',NULL,1222.000,2133.060,-911.060,1,'Madera',3,'2019-01-03 22:56:50',0,NULL,6),(4,1,1,'Torito',2,50,'FC6547',NULL,6554.000,93.160,6460.840,1,'Madera',3,'2019-01-03 23:24:20',0,NULL,1),(5,1,1,'Torito',2,12,'FC001',NULL,100.000,24.760,75.240,1,'Madera',3,'2019-01-04 00:12:40',1,'35',1),(6,1,1,'Torito',2,50,'AZ001',NULL,100.000,93.160,6.840,1,'Madera',3,'2019-01-04 12:04:41',0,'18',1),(6,2,1,'Torito',2,10,'az002',NULL,200.000,21.160,178.840,1,'Madera',3,'2019-01-04 12:05:03',0,NULL,2),(6,3,1,'Torito',2,50,'az003',NULL,300.000,93.160,206.840,1,'Madera',3,'2019-01-04 12:05:19',0,NULL,3),(6,4,1,'Torito',2,12,'az004',NULL,111.000,24.760,86.240,1,'Madera',3,'2019-01-04 12:06:04',0,NULL,4),(6,5,1,'Torito',2,122,'az006',NULL,6554.000,222.760,6331.240,1,'Madera',3,'2019-01-04 12:06:20',0,NULL,5),(6,6,1,'Torito',2,10,'az007',NULL,700.000,21.160,678.840,1,'Madera',3,'2019-01-04 12:06:33',0,NULL,6),(6,7,1,'Torito',2,12,'az008',NULL,121.000,24.760,96.240,1,'Madera',3,'2019-01-04 12:06:47',0,NULL,7),(6,8,1,'Torito',2,10,'az009',NULL,121.000,21.160,99.840,1,'Madera',3,'2019-01-04 12:06:59',0,'17',8),(6,9,1,'Torito',2,20,'az010',NULL,1000.000,39.160,960.840,1,'Madera',3,'2019-01-04 12:07:18',0,NULL,9),(6,10,1,'Torito',2,12,'az011',NULL,1122.000,24.760,1097.240,1,'Madera',3,'2019-01-04 12:07:40',0,NULL,10),(7,1,1,'Torito',2,100,'fc001',1221.000,1221.000,183.160,1037.840,1,'Madera',3,'2019-01-05 01:36:01',1,'35',1),(9,1,1,'Torito',2,12,'fc099',211.000,211.000,24.760,186.240,1,'Madera',3,'2019-01-07 17:41:05',0,NULL,1),(12,1,1,'Torito',2,12,'FC02',123.100,123.100,24.760,1206.240,1,'Madera',3,'2019-01-10 16:14:26',0,NULL,1),(12,2,1,'Torito',2,12,'FC21',122.000,122.000,24.760,97.240,1,'Madera',3,'2019-01-10 16:16:21',0,NULL,2),(12,3,1,'Torito',2,12,'FC021',123.200,123.200,24.760,1207.240,1,'Madera',3,'2019-01-10 16:26:54',0,NULL,3),(11,1,1,'Torito',2,12,'1234',123.000,123.000,26.300,96.700,2,'Metal',5,'2019-01-10 16:42:22',0,NULL,1),(11,2,2,'Blanco/Amarillo',2,12,'112233',123.000,123.000,27.500,95.500,2,'Metal',5,'2019-01-10 16:43:04',0,NULL,2),(11,3,3,'Verde',2,2,'12',124.000,124.000,5.481,118.519,3,'Plastico',2,'2019-01-10 16:43:35',0,NULL,3),(13,1,5,'Rojo',2,12,'412',123.000,123.000,21.760,101.240,1,'Madera',3,'2019-01-10 16:46:09',0,NULL,1),(13,2,3,'Verde',2,21,'123412',231.000,231.000,40.442,190.558,2,'Metal',5,'2019-01-10 16:46:45',0,NULL,2),(13,3,4,'Azul',2,12,'1414',132.000,132.000,20.077,111.923,3,'Plastico',2,'2019-01-10 16:47:13',0,NULL,3);
/*!40000 ALTER TABLE `tbl_recepcion_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tipo_usuario`
--

DROP TABLE IF EXISTS `tbl_tipo_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_tipo_usuario` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tipo_usuario`
--

LOCK TABLES `tbl_tipo_usuario` WRITE;
/*!40000 ALTER TABLE `tbl_tipo_usuario` DISABLE KEYS */;
INSERT INTO `tbl_tipo_usuario` VALUES (1,'Administrador'),(2,'Limitado');
/*!40000 ALTER TABLE `tbl_tipo_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tipo_usuario_permisos`
--

DROP TABLE IF EXISTS `tbl_tipo_usuario_permisos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_tipo_usuario_permisos` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `id_tipo_usuario` bigint(20) NOT NULL,
  `permisos` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tipo_usuario_permisos`
--

LOCK TABLES `tbl_tipo_usuario_permisos` WRITE;
/*!40000 ALTER TABLE `tbl_tipo_usuario_permisos` DISABLE KEYS */;
INSERT INTO `tbl_tipo_usuario_permisos` VALUES (1,1,'1,2,3,4'),(2,2,'1');
/*!40000 ALTER TABLE `tbl_tipo_usuario_permisos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tipoarmado`
--

DROP TABLE IF EXISTS `tbl_tipoarmado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_tipoarmado` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50) DEFAULT NULL,
  UNIQUE KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tipoarmado`
--

LOCK TABLES `tbl_tipoarmado` WRITE;
/*!40000 ALTER TABLE `tbl_tipoarmado` DISABLE KEYS */;
INSERT INTO `tbl_tipoarmado` VALUES (1,'Maritimo-'),(2,'Guarda+'),(3,'Aereo*');
/*!40000 ALTER TABLE `tbl_tipoarmado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tipocomercial`
--

DROP TABLE IF EXISTS `tbl_tipocomercial`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_tipocomercial` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tipocomercial`
--

LOCK TABLES `tbl_tipocomercial` WRITE;
/*!40000 ALTER TABLE `tbl_tipocomercial` DISABLE KEYS */;
INSERT INTO `tbl_tipocomercial` VALUES (1,'Comercial'),(2,'Merma');
/*!40000 ALTER TABLE `tbl_tipocomercial` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tipodescarga`
--

DROP TABLE IF EXISTS `tbl_tipodescarga`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_tipodescarga` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tipodescarga`
--

LOCK TABLES `tbl_tipodescarga` WRITE;
/*!40000 ALTER TABLE `tbl_tipodescarga` DISABLE KEYS */;
INSERT INTO `tbl_tipodescarga` VALUES (1,'Paletizado'),(2,'Piso');
/*!40000 ALTER TABLE `tbl_tipodescarga` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tipomercado`
--

DROP TABLE IF EXISTS `tbl_tipomercado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_tipomercado` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tipomercado`
--

LOCK TABLES `tbl_tipomercado` WRITE;
/*!40000 ALTER TABLE `tbl_tipomercado` DISABLE KEYS */;
INSERT INTO `tbl_tipomercado` VALUES (1,'EEUU'),(2,'CHINA'),(3,'EUROPA');
/*!40000 ALTER TABLE `tbl_tipomercado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tiporecepcion`
--

DROP TABLE IF EXISTS `tbl_tiporecepcion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_tiporecepcion` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tiporecepcion`
--

LOCK TABLES `tbl_tiporecepcion` WRITE;
/*!40000 ALTER TABLE `tbl_tiporecepcion` DISABLE KEYS */;
INSERT INTO `tbl_tiporecepcion` VALUES (1,'Convencional'),(2,'Organico');
/*!40000 ALTER TABLE `tbl_tiporecepcion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_usuario`
--

DROP TABLE IF EXISTS `tbl_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_usuario` (
  `usuario` varchar(15) NOT NULL,
  `contrasenia` varchar(20) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `apellido` varchar(30) NOT NULL,
  `id_tipo_usuario` bigint(20) NOT NULL,
  PRIMARY KEY (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_usuario`
--

LOCK TABLES `tbl_usuario` WRITE;
/*!40000 ALTER TABLE `tbl_usuario` DISABLE KEYS */;
INSERT INTO `tbl_usuario` VALUES ('lsalas','123','Luis','Salas',2),('usuario','1234','Fulano','Henriquez',1);
/*!40000 ALTER TABLE `tbl_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_variedad`
--

DROP TABLE IF EXISTS `tbl_variedad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_variedad` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_variedad`
--

LOCK TABLES `tbl_variedad` WRITE;
/*!40000 ALTER TABLE `tbl_variedad` DISABLE KEYS */;
INSERT INTO `tbl_variedad` VALUES (1,'Emeral *1'),(2,'Emeral *2'),(3,'Emeral *3'),(4,'Emeral *4');
/*!40000 ALTER TABLE `tbl_variedad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `v_comercial_maquila`
--

DROP TABLE IF EXISTS `v_comercial_maquila`;
/*!50001 DROP VIEW IF EXISTS `v_comercial_maquila`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `v_comercial_maquila` AS SELECT 
 1 AS `ID_Cliente`,
 1 AS `ID_Productor`,
 1 AS `ID_Tipo`,
 1 AS `Tipo`,
 1 AS `folio`,
 1 AS `kilos_netos`,
 1 AS `estado`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_exportacion_maquila`
--

DROP TABLE IF EXISTS `v_exportacion_maquila`;
/*!50001 DROP VIEW IF EXISTS `v_exportacion_maquila`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `v_exportacion_maquila` AS SELECT 
 1 AS `ID_cliente`,
 1 AS `ID_productor`,
 1 AS `Folio`,
 1 AS `ID_Embalaje`,
 1 AS `Embalaje`,
 1 AS `peso_teorico`,
 1 AS `cantidad_cajas`,
 1 AS `Total_Peso`,
 1 AS `cantidad_potes`,
 1 AS `estado`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_recepcion_maquila`
--

DROP TABLE IF EXISTS `v_recepcion_maquila`;
/*!50001 DROP VIEW IF EXISTS `v_recepcion_maquila`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `v_recepcion_maquila` AS SELECT 
 1 AS `ID_Cliente`,
 1 AS `ID_Productor`,
 1 AS `folio`,
 1 AS `bandeja`,
 1 AS `kilos_netos`,
 1 AS `cantidad_bandejas`,
 1 AS `estado`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping events for database 'packing'
--

--
-- Dumping routines for database 'packing'
--

--
-- Final view structure for view `v_comercial_maquila`
--

/*!50001 DROP VIEW IF EXISTS `v_comercial_maquila`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`atc`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `v_comercial_maquila` AS select `t1`.`ID_Cliente` AS `ID_Cliente`,`t1`.`ID_Productor` AS `ID_Productor`,`t1`.`ID_Tipo` AS `ID_Tipo`,`t2`.`descripcion` AS `Tipo`,`t1`.`folio` AS `folio`,`t1`.`kilos_netos` AS `kilos_netos`,`t1`.`estado` AS `estado` from (`tbl_comercial` `t1` left join `tbl_tipocomercial` `t2` on((`t2`.`ID` = `t1`.`ID_Tipo`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_exportacion_maquila`
--

/*!50001 DROP VIEW IF EXISTS `v_exportacion_maquila`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`atc`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `v_exportacion_maquila` AS select `t1`.`ID_Cliente` AS `ID_cliente`,`t1`.`ID_Productor` AS `ID_productor`,`t1`.`Folio` AS `Folio`,`t1`.`ID_Embalaje` AS `ID_Embalaje`,`t2`.`descripcion` AS `Embalaje`,`t2`.`peso` AS `peso_teorico`,`t1`.`cantidad_cajas` AS `cantidad_cajas`,(`t1`.`cantidad_cajas` * `t2`.`peso`) AS `Total_Peso`,(`t1`.`cantidad_cajas` * `t2`.`potes`) AS `cantidad_potes`,`t1`.`estado` AS `estado` from (`tbl_exportacion` `t1` left join `tbl_embalaje` `t2` on((`t2`.`ID` = `t1`.`ID_Embalaje`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_recepcion_maquila`
--

/*!50001 DROP VIEW IF EXISTS `v_recepcion_maquila`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`atc`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `v_recepcion_maquila` AS select `t2`.`ID_cliente` AS `ID_Cliente`,`t2`.`ID_productor` AS `ID_Productor`,`t1`.`folio` AS `folio`,`t1`.`bandeja` AS `bandeja`,`t1`.`kilos_netos` AS `kilos_netos`,`t1`.`cantidad_bandejas` AS `cantidad_bandejas`,`t1`.`estado` AS `estado` from (`tbl_recepcion_detalle` `t1` left join `tbl_recepcion` `t2` on((`t2`.`ID` = `t1`.`ID_Recepcion`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-01-13 12:58:04
