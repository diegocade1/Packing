/*
SQLyog Community Edition- MySQL GUI v6.07
Host - 5.6.21-log : Database - packing
*********************************************************************
Server version : 5.6.21-log
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

create database if not exists `packing`;

/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

/*Table structure for table `tbl_bandeja` */

DROP TABLE IF EXISTS `tbl_bandeja`;

CREATE TABLE `tbl_bandeja` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(50) NOT NULL,
  `Peso` decimal(5,3) NOT NULL DEFAULT '0.000',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_bandeja` */

insert  into `tbl_bandeja`(`ID`,`Descripcion`,`Peso`) values (1,'Torito','1.800');
insert  into `tbl_bandeja`(`ID`,`Descripcion`,`Peso`) values (2,'Blanco/Amarillo','1.900');
insert  into `tbl_bandeja`(`ID`,`Descripcion`,`Peso`) values (3,'Verde','1.702');
insert  into `tbl_bandeja`(`ID`,`Descripcion`,`Peso`) values (4,'Azul','1.500');
insert  into `tbl_bandeja`(`ID`,`Descripcion`,`Peso`) values (5,'Rojo','1.550');

/*Table structure for table `tbl_cliente` */

DROP TABLE IF EXISTS `tbl_cliente`;

CREATE TABLE `tbl_cliente` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Codigo` varchar(50) NOT NULL,
  `Cliente` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=1772 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_cliente` */

insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (6,'6','Bazo');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (7,'7','cool&go');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (509,'1001','Cliente 1');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (510,'1002','Cliente 2');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (511,'1003','Cliente 3');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (512,'1004','Cliente 4');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (513,'1005','Cliente 5');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (514,'1006','Cliente 6');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (515,'1007','Cliente 7');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (516,'1008','Cliente 8');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (517,'1009','Cliente 9');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (518,'1010','Cliente 10');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (519,'1011','Cliente 11');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (520,'1012','Cliente 12');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (521,'1013','Cliente 13');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (522,'1014','Cliente 14');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (523,'1015','Cliente 15');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (524,'1016','Cliente 16');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (525,'1017','Cliente 17');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (526,'1018','Cliente 18');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (527,'1019','Cliente 19');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (528,'1020','Cliente 20');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (529,'1021','Cliente 21');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (530,'1022','Cliente 22');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (531,'1023','Cliente 23');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (532,'1024','Cliente 24');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (533,'1025','Cliente 25');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (534,'1026','Cliente 26');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (535,'1027','Cliente 27');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (536,'1028','Cliente 28');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (537,'1029','Cliente 29');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (538,'1030','Cliente 30');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (539,'1031','Cliente 31');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (540,'1032','Cliente 32');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (541,'1033','Cliente 33');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (542,'1034','Cliente 34');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (543,'1035','Cliente 35');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (544,'1036','Cliente 36');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (545,'1037','Cliente 37');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (546,'1038','Cliente 38');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (547,'1039','Cliente 39');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (548,'1040','Cliente 40');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (549,'1041','Cliente 41');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (550,'1042','Cliente 42');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (551,'1043','Cliente 43');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (552,'1044','Cliente 44');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (553,'1045','Cliente 45');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (554,'1046','Cliente 46');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (555,'1047','Cliente 47');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (556,'1048','Cliente 48');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (557,'1049','Cliente 49');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (558,'1050','Cliente 50');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (559,'1051','Cliente 51');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (560,'1052','Cliente 52');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (561,'1053','Cliente 53');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (562,'1054','Cliente 54');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (563,'1055','Cliente 55');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (564,'1056','Cliente 56');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (565,'1057','Cliente 57');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (566,'1058','Cliente 58');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (567,'1059','Cliente 59');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (568,'1060','Cliente 60');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (569,'1061','Cliente 61');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (570,'1062','Cliente 62');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (571,'1063','Cliente 63');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (572,'1064','Cliente 64');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (573,'1065','Cliente 65');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (574,'1066','Cliente 66');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (575,'1067','Cliente 67');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (576,'1068','Cliente 68');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (577,'1069','Cliente 69');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (578,'1070','Cliente 70');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (579,'1071','Cliente 71');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (580,'1072','Cliente 72');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (581,'1073','Cliente 73');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (582,'1074','Cliente 74');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (583,'1075','Cliente 75');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (584,'1076','Cliente 76');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (585,'1077','Cliente 77');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (586,'1078','Cliente 78');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (587,'1079','Cliente 79');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (588,'1080','Cliente 80');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (589,'1081','Cliente 81');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (590,'1082','Cliente 82');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (591,'1083','Cliente 83');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (592,'1084','Cliente 84');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (593,'1085','Cliente 85');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (594,'1086','Cliente 86');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (595,'1087','Cliente 87');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (596,'1088','Cliente 88');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (597,'1089','Cliente 89');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (598,'1090','Cliente 90');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (599,'1091','Cliente 91');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (600,'1092','Cliente 92');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (601,'1093','Cliente 93');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (602,'1094','Cliente 94');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (603,'1095','Cliente 95');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (604,'1096','Cliente 96');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (605,'1097','Cliente 97');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (606,'1098','Cliente 98');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (607,'1099','Cliente 99');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (608,'1100','Cliente 100');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (609,'1101','Cliente 101');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (610,'1102','Cliente 102');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (611,'1103','Cliente 103');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (612,'1104','Cliente 104');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (613,'1105','Cliente 105');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (614,'1106','Cliente 106');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (615,'1107','Cliente 107');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (616,'1108','Cliente 108');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (617,'1109','Cliente 109');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (618,'1110','Cliente 110');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (619,'1111','Cliente 111');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (620,'1112','Cliente 112');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (621,'1113','Cliente 113');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (622,'1114','Cliente 114');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (623,'1115','Cliente 115');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (624,'1116','Cliente 116');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (625,'1117','Cliente 117');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (626,'1118','Cliente 118');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (627,'1119','Cliente 119');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (628,'1120','Cliente 120');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (629,'1121','Cliente 121');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (630,'1122','Cliente 122');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (631,'1123','Cliente 123');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (632,'1124','Cliente 124');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (633,'1125','Cliente 125');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (634,'1126','Cliente 126');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (635,'1127','Cliente 127');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (636,'1128','Cliente 128');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (637,'1129','Cliente 129');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (638,'1130','Cliente 130');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (639,'1131','Cliente 131');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (640,'1132','Cliente 132');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (641,'1133','Cliente 133');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (642,'1134','Cliente 134');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (643,'1135','Cliente 135');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (644,'1136','Cliente 136');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (645,'1137','Cliente 137');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (646,'1138','Cliente 138');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (647,'1139','Cliente 139');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (648,'1140','Cliente 140');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (649,'1141','Cliente 141');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (650,'1142','Cliente 142');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (651,'1143','Cliente 143');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (652,'1144','Cliente 144');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (653,'1145','Cliente 145');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (654,'1146','Cliente 146');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (655,'1147','Cliente 147');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (656,'1148','Cliente 148');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (657,'1149','Cliente 149');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (658,'1150','Cliente 150');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (659,'1151','Cliente 151');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (660,'1152','Cliente 152');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (661,'1153','Cliente 153');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (662,'1154','Cliente 154');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (663,'1155','Cliente 155');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (664,'1156','Cliente 156');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (665,'1157','Cliente 157');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (666,'1158','Cliente 158');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (667,'1159','Cliente 159');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (668,'1160','Cliente 160');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (669,'1161','Cliente 161');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (670,'1162','Cliente 162');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (671,'1163','Cliente 163');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (672,'1164','Cliente 164');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (673,'1165','Cliente 165');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (674,'1166','Cliente 166');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (675,'1167','Cliente 167');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (676,'1168','Cliente 168');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (677,'1169','Cliente 169');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (678,'1170','Cliente 170');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (679,'1171','Cliente 171');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (680,'1172','Cliente 172');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (681,'1173','Cliente 173');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (682,'1174','Cliente 174');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (683,'1175','Cliente 175');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (684,'1176','Cliente 176');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (685,'1177','Cliente 177');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (686,'1178','Cliente 178');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (687,'1179','Cliente 179');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (688,'1180','Cliente 180');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (689,'1181','Cliente 181');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (690,'1182','Cliente 182');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (691,'1183','Cliente 183');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (692,'1184','Cliente 184');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (693,'1185','Cliente 185');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (694,'1186','Cliente 186');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (695,'1187','Cliente 187');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (696,'1188','Cliente 188');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (697,'1189','Cliente 189');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (698,'1190','Cliente 190');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (699,'1191','Cliente 191');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (700,'1192','Cliente 192');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (701,'1193','Cliente 193');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (702,'1194','Cliente 194');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (703,'1195','Cliente 195');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (704,'1196','Cliente 196');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (705,'1197','Cliente 197');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (706,'1198','Cliente 198');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (707,'1199','Cliente 199');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (708,'1200','Cliente 200');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (709,'1201','Cliente 201');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (710,'1202','Cliente 202');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (711,'1203','Cliente 203');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (712,'1204','Cliente 204');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (713,'1205','Cliente 205');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (714,'1206','Cliente 206');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (715,'1207','Cliente 207');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (716,'1208','Cliente 208');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (717,'1209','Cliente 209');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (718,'1210','Cliente 210');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (719,'1211','Cliente 211');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (720,'1212','Cliente 212');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (721,'1213','Cliente 213');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (722,'1214','Cliente 214');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (723,'1215','Cliente 215');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (724,'1216','Cliente 216');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (725,'1217','Cliente 217');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (726,'1218','Cliente 218');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (727,'1219','Cliente 219');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (728,'1220','Cliente 220');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (729,'1221','Cliente 221');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (730,'1222','Cliente 222');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (731,'1223','Cliente 223');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (732,'1224','Cliente 224');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (733,'1225','Cliente 225');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (734,'1226','Cliente 226');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (735,'1227','Cliente 227');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (736,'1228','Cliente 228');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (737,'1229','Cliente 229');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (738,'1230','Cliente 230');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (739,'1231','Cliente 231');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (740,'1232','Cliente 232');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (741,'1233','Cliente 233');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (742,'1234','Cliente 234');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (743,'1235','Cliente 235');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (744,'1236','Cliente 236');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (745,'1237','Cliente 237');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (746,'1238','Cliente 238');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (747,'1239','Cliente 239');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (748,'1240','Cliente 240');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (749,'1241','Cliente 241');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (750,'1242','Cliente 242');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (751,'1243','Cliente 243');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (752,'1244','Cliente 244');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (753,'1245','Cliente 245');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (754,'1246','Cliente 246');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (755,'1247','Cliente 247');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (756,'1248','Cliente 248');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (757,'1249','Cliente 249');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (758,'1250','Cliente 250');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (759,'1251','Cliente 251');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (760,'1252','Cliente 252');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (761,'1253','Cliente 253');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (762,'1254','Cliente 254');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (763,'1255','Cliente 255');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (764,'1256','Cliente 256');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (765,'1257','Cliente 257');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (766,'1258','Cliente 258');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (767,'1259','Cliente 259');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (768,'1260','Cliente 260');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (769,'1261','Cliente 261');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (770,'1262','Cliente 262');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (771,'1263','Cliente 263');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (772,'1264','Cliente 264');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (773,'1265','Cliente 265');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (774,'1266','Cliente 266');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (775,'1267','Cliente 267');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (776,'1268','Cliente 268');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (777,'1269','Cliente 269');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (778,'1270','Cliente 270');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (779,'1271','Cliente 271');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (780,'1272','Cliente 272');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (781,'1273','Cliente 273');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (782,'1274','Cliente 274');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (783,'1275','Cliente 275');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (784,'1276','Cliente 276');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (785,'1277','Cliente 277');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (786,'1278','Cliente 278');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (787,'1279','Cliente 279');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (788,'1280','Cliente 280');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (789,'1281','Cliente 281');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (790,'1282','Cliente 282');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (791,'1283','Cliente 283');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (792,'1284','Cliente 284');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (793,'1285','Cliente 285');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (794,'1286','Cliente 286');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (795,'1287','Cliente 287');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (796,'1288','Cliente 288');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (797,'1289','Cliente 289');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (798,'1290','Cliente 290');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (799,'1291','Cliente 291');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (800,'1292','Cliente 292');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (801,'1293','Cliente 293');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (802,'1294','Cliente 294');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (803,'1295','Cliente 295');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (804,'1296','Cliente 296');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (805,'1297','Cliente 297');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (806,'1298','Cliente 298');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (807,'1299','Cliente 299');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (808,'1300','Cliente 300');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (809,'1301','Cliente 301');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (810,'1302','Cliente 302');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (811,'1303','Cliente 303');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (812,'1304','Cliente 304');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (813,'1305','Cliente 305');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (814,'1306','Cliente 306');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (815,'1307','Cliente 307');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (816,'1308','Cliente 308');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (817,'1309','Cliente 309');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (818,'1310','Cliente 310');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (819,'1311','Cliente 311');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (820,'1312','Cliente 312');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (821,'1313','Cliente 313');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (822,'1314','Cliente 314');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (823,'1315','Cliente 315');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (824,'1316','Cliente 316');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (825,'1317','Cliente 317');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (826,'1318','Cliente 318');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (827,'1319','Cliente 319');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (828,'1320','Cliente 320');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (829,'1321','Cliente 321');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (830,'1322','Cliente 322');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (831,'1323','Cliente 323');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (832,'1324','Cliente 324');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (833,'1325','Cliente 325');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (834,'1326','Cliente 326');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (835,'1327','Cliente 327');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (836,'1328','Cliente 328');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (837,'1329','Cliente 329');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (838,'1330','Cliente 330');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (839,'1331','Cliente 331');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (840,'1332','Cliente 332');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (841,'1333','Cliente 333');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (842,'1334','Cliente 334');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (843,'1335','Cliente 335');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (844,'1336','Cliente 336');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (845,'1337','Cliente 337');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (846,'1338','Cliente 338');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (847,'1339','Cliente 339');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (848,'1340','Cliente 340');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (849,'1341','Cliente 341');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (850,'1342','Cliente 342');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (851,'1343','Cliente 343');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (852,'1344','Cliente 344');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (853,'1345','Cliente 345');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (854,'1346','Cliente 346');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (855,'1347','Cliente 347');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (856,'1348','Cliente 348');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (857,'1349','Cliente 349');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (858,'1350','Cliente 350');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (859,'1351','Cliente 351');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (860,'1352','Cliente 352');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (861,'1353','Cliente 353');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (862,'1354','Cliente 354');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (863,'1355','Cliente 355');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (864,'1356','Cliente 356');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (865,'1357','Cliente 357');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (866,'1358','Cliente 358');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (867,'1359','Cliente 359');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (868,'1360','Cliente 360');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (869,'1361','Cliente 361');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (870,'1362','Cliente 362');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (871,'1363','Cliente 363');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (872,'1364','Cliente 364');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (873,'1365','Cliente 365');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (874,'1366','Cliente 366');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (875,'1367','Cliente 367');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (876,'1368','Cliente 368');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (877,'1369','Cliente 369');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (878,'1370','Cliente 370');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (879,'1371','Cliente 371');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (880,'1372','Cliente 372');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (881,'1373','Cliente 373');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (882,'1374','Cliente 374');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (883,'1375','Cliente 375');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (884,'1376','Cliente 376');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (885,'1377','Cliente 377');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (886,'1378','Cliente 378');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (887,'1379','Cliente 379');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (888,'1380','Cliente 380');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (889,'1381','Cliente 381');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (890,'1382','Cliente 382');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (891,'1383','Cliente 383');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (892,'1384','Cliente 384');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (893,'1385','Cliente 385');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (894,'1386','Cliente 386');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (895,'1387','Cliente 387');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (896,'1388','Cliente 388');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (897,'1389','Cliente 389');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (898,'1390','Cliente 390');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (899,'1391','Cliente 391');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (900,'1392','Cliente 392');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (901,'1393','Cliente 393');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (902,'1394','Cliente 394');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (903,'1395','Cliente 395');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (904,'1396','Cliente 396');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (905,'1397','Cliente 397');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (906,'1398','Cliente 398');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (907,'1399','Cliente 399');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (908,'1400','Cliente 400');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (909,'1401','Cliente 401');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (910,'1402','Cliente 402');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (911,'1403','Cliente 403');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (912,'1404','Cliente 404');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (913,'1405','Cliente 405');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (914,'1406','Cliente 406');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (915,'1407','Cliente 407');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (916,'1408','Cliente 408');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (917,'1409','Cliente 409');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (918,'1410','Cliente 410');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (919,'1411','Cliente 411');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (920,'1412','Cliente 412');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (921,'1413','Cliente 413');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (922,'1414','Cliente 414');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (923,'1415','Cliente 415');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (924,'1416','Cliente 416');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (925,'1417','Cliente 417');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (926,'1418','Cliente 418');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (927,'1419','Cliente 419');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (928,'1420','Cliente 420');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (929,'1421','Cliente 421');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (930,'1422','Cliente 422');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (931,'1423','Cliente 423');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (932,'1424','Cliente 424');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (933,'1425','Cliente 425');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (934,'1426','Cliente 426');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (935,'1427','Cliente 427');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (936,'1428','Cliente 428');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (937,'1429','Cliente 429');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (938,'1430','Cliente 430');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (939,'1431','Cliente 431');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (940,'1432','Cliente 432');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (941,'1433','Cliente 433');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (942,'1434','Cliente 434');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (943,'1435','Cliente 435');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (944,'1436','Cliente 436');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (945,'1437','Cliente 437');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (946,'1438','Cliente 438');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (947,'1439','Cliente 439');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (948,'1440','Cliente 440');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (949,'1441','Cliente 441');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (950,'1442','Cliente 442');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (951,'1443','Cliente 443');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (952,'1444','Cliente 444');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (953,'1445','Cliente 445');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (954,'1446','Cliente 446');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (955,'1447','Cliente 447');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (956,'1448','Cliente 448');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (957,'1449','Cliente 449');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (958,'1450','Cliente 450');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (959,'1451','Cliente 451');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (960,'1452','Cliente 452');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (961,'1453','Cliente 453');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (962,'1454','Cliente 454');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (963,'1455','Cliente 455');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (964,'1456','Cliente 456');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (965,'1457','Cliente 457');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (966,'1458','Cliente 458');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (967,'1459','Cliente 459');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (968,'1460','Cliente 460');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (969,'1461','Cliente 461');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (970,'1462','Cliente 462');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (971,'1463','Cliente 463');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (972,'1464','Cliente 464');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (973,'1465','Cliente 465');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (974,'1466','Cliente 466');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (975,'1467','Cliente 467');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (976,'1468','Cliente 468');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (977,'1469','Cliente 469');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (978,'1470','Cliente 470');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (979,'1471','Cliente 471');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (980,'1472','Cliente 472');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (981,'1473','Cliente 473');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (982,'1474','Cliente 474');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (983,'1475','Cliente 475');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (984,'1476','Cliente 476');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (985,'1477','Cliente 477');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (986,'1478','Cliente 478');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (987,'1479','Cliente 479');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (988,'1480','Cliente 480');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (989,'1481','Cliente 481');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (990,'1482','Cliente 482');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (991,'1483','Cliente 483');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (992,'1484','Cliente 484');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (993,'1485','Cliente 485');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (994,'1486','Cliente 486');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (995,'1487','Cliente 487');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (996,'1488','Cliente 488');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (997,'1489','Cliente 489');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (998,'1490','Cliente 490');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (999,'1491','Cliente 491');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1000,'1492','Cliente 492');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1001,'1493','Cliente 493');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1002,'1494','Cliente 494');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1003,'1495','Cliente 495');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1004,'1496','Cliente 496');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1005,'1497','Cliente 497');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1006,'1498','Cliente 498');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1007,'1499','Cliente 499');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1008,'1500','Cliente 500');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1009,'1501','Cliente 501');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1010,'1502','Cliente 502');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1011,'1503','Cliente 503');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1012,'1504','Cliente 504');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1013,'1505','Cliente 505');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1014,'1506','Cliente 506');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1015,'1507','Cliente 507');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1016,'1508','Cliente 508');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1017,'1509','Cliente 509');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1018,'1510','Cliente 510');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1019,'1511','Cliente 511');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1020,'1512','Cliente 512');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1021,'1513','Cliente 513');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1022,'1514','Cliente 514');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1023,'1515','Cliente 515');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1024,'1516','Cliente 516');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1025,'1517','Cliente 517');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1026,'1518','Cliente 518');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1027,'1519','Cliente 519');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1028,'1520','Cliente 520');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1029,'1521','Cliente 521');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1030,'1522','Cliente 522');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1031,'1523','Cliente 523');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1032,'1524','Cliente 524');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1033,'1525','Cliente 525');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1034,'1526','Cliente 526');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1035,'1527','Cliente 527');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1036,'1528','Cliente 528');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1037,'1529','Cliente 529');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1038,'1530','Cliente 530');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1039,'1531','Cliente 531');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1040,'1532','Cliente 532');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1041,'1533','Cliente 533');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1042,'1534','Cliente 534');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1043,'1535','Cliente 535');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1044,'1536','Cliente 536');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1045,'1537','Cliente 537');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1046,'1538','Cliente 538');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1047,'1539','Cliente 539');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1048,'1540','Cliente 540');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1049,'1541','Cliente 541');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1050,'1542','Cliente 542');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1051,'1543','Cliente 543');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1052,'1544','Cliente 544');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1053,'1545','Cliente 545');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1054,'1546','Cliente 546');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1055,'1547','Cliente 547');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1056,'1548','Cliente 548');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1057,'1549','Cliente 549');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1058,'1550','Cliente 550');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1059,'1551','Cliente 551');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1060,'1552','Cliente 552');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1061,'1553','Cliente 553');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1062,'1554','Cliente 554');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1063,'1555','Cliente 555');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1064,'1556','Cliente 556');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1065,'1557','Cliente 557');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1066,'1558','Cliente 558');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1067,'1559','Cliente 559');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1068,'1560','Cliente 560');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1069,'1561','Cliente 561');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1070,'1562','Cliente 562');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1071,'1563','Cliente 563');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1072,'1564','Cliente 564');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1073,'1565','Cliente 565');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1074,'1566','Cliente 566');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1075,'1567','Cliente 567');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1076,'1568','Cliente 568');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1077,'1569','Cliente 569');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1078,'1570','Cliente 570');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1079,'1571','Cliente 571');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1080,'1572','Cliente 572');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1081,'1573','Cliente 573');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1082,'1574','Cliente 574');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1083,'1575','Cliente 575');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1084,'1576','Cliente 576');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1085,'1577','Cliente 577');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1086,'1578','Cliente 578');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1087,'1579','Cliente 579');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1088,'1580','Cliente 580');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1089,'1581','Cliente 581');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1090,'1582','Cliente 582');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1091,'1583','Cliente 583');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1092,'1584','Cliente 584');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1093,'1585','Cliente 585');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1094,'1586','Cliente 586');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1095,'1587','Cliente 587');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1096,'1588','Cliente 588');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1097,'1589','Cliente 589');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1098,'1590','Cliente 590');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1099,'1591','Cliente 591');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1100,'1592','Cliente 592');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1101,'1593','Cliente 593');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1102,'1594','Cliente 594');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1103,'1595','Cliente 595');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1104,'1596','Cliente 596');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1105,'1597','Cliente 597');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1106,'1598','Cliente 598');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1107,'1599','Cliente 599');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1108,'1600','Cliente 600');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1109,'1601','Cliente 601');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1110,'1602','Cliente 602');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1111,'1603','Cliente 603');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1112,'1604','Cliente 604');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1113,'1605','Cliente 605');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1114,'1606','Cliente 606');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1115,'1607','Cliente 607');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1116,'1608','Cliente 608');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1117,'1609','Cliente 609');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1118,'1610','Cliente 610');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1119,'1611','Cliente 611');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1120,'1612','Cliente 612');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1121,'1613','Cliente 613');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1122,'1614','Cliente 614');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1123,'1615','Cliente 615');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1124,'1616','Cliente 616');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1125,'1617','Cliente 617');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1126,'1618','Cliente 618');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1127,'1619','Cliente 619');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1128,'1620','Cliente 620');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1129,'1621','Cliente 621');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1130,'1622','Cliente 622');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1131,'1623','Cliente 623');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1132,'1624','Cliente 624');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1133,'1625','Cliente 625');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1134,'1626','Cliente 626');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1135,'1627','Cliente 627');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1136,'1628','Cliente 628');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1137,'1629','Cliente 629');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1138,'1630','Cliente 630');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1139,'1631','Cliente 631');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1140,'1632','Cliente 632');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1141,'1633','Cliente 633');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1142,'1634','Cliente 634');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1143,'1635','Cliente 635');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1144,'1636','Cliente 636');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1145,'1637','Cliente 637');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1146,'1638','Cliente 638');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1147,'1639','Cliente 639');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1148,'1640','Cliente 640');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1149,'1641','Cliente 641');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1150,'1642','Cliente 642');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1151,'1643','Cliente 643');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1152,'1644','Cliente 644');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1153,'1645','Cliente 645');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1154,'1646','Cliente 646');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1155,'1647','Cliente 647');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1156,'1648','Cliente 648');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1157,'1649','Cliente 649');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1158,'1650','Cliente 650');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1159,'1651','Cliente 651');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1160,'1652','Cliente 652');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1161,'1653','Cliente 653');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1162,'1654','Cliente 654');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1163,'1655','Cliente 655');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1164,'1656','Cliente 656');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1165,'1657','Cliente 657');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1166,'1658','Cliente 658');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1167,'1659','Cliente 659');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1168,'1660','Cliente 660');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1169,'1661','Cliente 661');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1170,'1662','Cliente 662');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1171,'1663','Cliente 663');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1172,'1664','Cliente 664');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1173,'1665','Cliente 665');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1174,'1666','Cliente 666');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1175,'1667','Cliente 667');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1176,'1668','Cliente 668');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1177,'1669','Cliente 669');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1178,'1670','Cliente 670');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1179,'1671','Cliente 671');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1180,'1672','Cliente 672');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1181,'1673','Cliente 673');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1182,'1674','Cliente 674');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1183,'1675','Cliente 675');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1184,'1676','Cliente 676');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1185,'1677','Cliente 677');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1186,'1678','Cliente 678');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1187,'1679','Cliente 679');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1188,'1680','Cliente 680');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1189,'1681','Cliente 681');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1190,'1682','Cliente 682');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1191,'1683','Cliente 683');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1192,'1684','Cliente 684');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1193,'1685','Cliente 685');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1194,'1686','Cliente 686');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1195,'1687','Cliente 687');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1196,'1688','Cliente 688');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1197,'1689','Cliente 689');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1198,'1690','Cliente 690');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1199,'1691','Cliente 691');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1200,'1692','Cliente 692');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1201,'1693','Cliente 693');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1202,'1694','Cliente 694');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1203,'1695','Cliente 695');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1204,'1696','Cliente 696');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1205,'1697','Cliente 697');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1206,'1698','Cliente 698');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1207,'1699','Cliente 699');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1208,'1700','Cliente 700');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1209,'1701','Cliente 701');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1210,'1702','Cliente 702');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1211,'1703','Cliente 703');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1212,'1704','Cliente 704');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1213,'1705','Cliente 705');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1214,'1706','Cliente 706');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1215,'1707','Cliente 707');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1216,'1708','Cliente 708');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1217,'1709','Cliente 709');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1218,'1710','Cliente 710');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1219,'1711','Cliente 711');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1220,'1712','Cliente 712');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1221,'1713','Cliente 713');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1222,'1714','Cliente 714');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1223,'1715','Cliente 715');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1224,'1716','Cliente 716');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1225,'1717','Cliente 717');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1226,'1718','Cliente 718');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1227,'1719','Cliente 719');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1228,'1720','Cliente 720');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1229,'1721','Cliente 721');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1230,'1722','Cliente 722');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1231,'1723','Cliente 723');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1232,'1724','Cliente 724');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1233,'1725','Cliente 725');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1234,'1726','Cliente 726');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1235,'1727','Cliente 727');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1236,'1728','Cliente 728');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1237,'1729','Cliente 729');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1238,'1730','Cliente 730');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1239,'1731','Cliente 731');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1240,'1732','Cliente 732');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1241,'1733','Cliente 733');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1242,'1734','Cliente 734');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1243,'1735','Cliente 735');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1244,'1736','Cliente 736');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1245,'1737','Cliente 737');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1246,'1738','Cliente 738');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1247,'1739','Cliente 739');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1248,'1740','Cliente 740');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1249,'1741','Cliente 741');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1250,'1742','Cliente 742');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1251,'1743','Cliente 743');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1252,'1744','Cliente 744');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1253,'1745','Cliente 745');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1254,'1746','Cliente 746');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1255,'1747','Cliente 747');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1256,'1748','Cliente 748');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1257,'1749','Cliente 749');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1258,'1750','Cliente 750');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1259,'1751','Cliente 751');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1260,'1752','Cliente 752');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1261,'1753','Cliente 753');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1262,'1754','Cliente 754');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1263,'1755','Cliente 755');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1264,'1756','Cliente 756');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1265,'1757','Cliente 757');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1266,'1758','Cliente 758');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1267,'1759','Cliente 759');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1268,'1760','Cliente 760');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1269,'1761','Cliente 761');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1270,'1762','Cliente 762');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1271,'1763','Cliente 763');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1272,'1764','Cliente 764');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1273,'1765','Cliente 765');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1274,'1766','Cliente 766');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1275,'1767','Cliente 767');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1276,'1768','Cliente 768');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1277,'1769','Cliente 769');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1278,'1770','Cliente 770');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1279,'1771','Cliente 771');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1280,'1772','Cliente 772');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1281,'1773','Cliente 773');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1282,'1774','Cliente 774');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1283,'1775','Cliente 775');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1284,'1776','Cliente 776');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1285,'1777','Cliente 777');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1286,'1778','Cliente 778');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1287,'1779','Cliente 779');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1288,'1780','Cliente 780');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1289,'1781','Cliente 781');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1290,'1782','Cliente 782');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1291,'1783','Cliente 783');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1292,'1784','Cliente 784');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1293,'1785','Cliente 785');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1294,'1786','Cliente 786');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1295,'1787','Cliente 787');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1296,'1788','Cliente 788');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1297,'1789','Cliente 789');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1298,'1790','Cliente 790');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1299,'1791','Cliente 791');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1300,'1792','Cliente 792');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1301,'1793','Cliente 793');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1302,'1794','Cliente 794');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1303,'1795','Cliente 795');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1304,'1796','Cliente 796');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1305,'1797','Cliente 797');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1306,'1798','Cliente 798');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1307,'1799','Cliente 799');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1308,'1800','Cliente 800');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1309,'1801','Cliente 801');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1310,'1802','Cliente 802');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1311,'1803','Cliente 803');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1312,'1804','Cliente 804');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1313,'1805','Cliente 805');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1314,'1806','Cliente 806');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1315,'1807','Cliente 807');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1316,'1808','Cliente 808');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1317,'1809','Cliente 809');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1318,'1810','Cliente 810');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1319,'1811','Cliente 811');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1320,'1812','Cliente 812');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1321,'1813','Cliente 813');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1322,'1814','Cliente 814');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1323,'1815','Cliente 815');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1324,'1816','Cliente 816');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1325,'1817','Cliente 817');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1326,'1818','Cliente 818');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1327,'1819','Cliente 819');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1328,'1820','Cliente 820');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1329,'1821','Cliente 821');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1330,'1822','Cliente 822');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1331,'1823','Cliente 823');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1332,'1824','Cliente 824');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1333,'1825','Cliente 825');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1334,'1826','Cliente 826');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1335,'1827','Cliente 827');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1336,'1828','Cliente 828');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1337,'1829','Cliente 829');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1338,'1830','Cliente 830');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1339,'1831','Cliente 831');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1340,'1832','Cliente 832');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1341,'1833','Cliente 833');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1342,'1834','Cliente 834');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1343,'1835','Cliente 835');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1344,'1836','Cliente 836');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1345,'1837','Cliente 837');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1346,'1838','Cliente 838');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1347,'1839','Cliente 839');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1348,'1840','Cliente 840');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1349,'1841','Cliente 841');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1350,'1842','Cliente 842');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1351,'1843','Cliente 843');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1352,'1844','Cliente 844');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1353,'1845','Cliente 845');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1354,'1846','Cliente 846');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1355,'1847','Cliente 847');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1356,'1848','Cliente 848');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1357,'1849','Cliente 849');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1358,'1850','Cliente 850');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1359,'1851','Cliente 851');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1360,'1852','Cliente 852');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1361,'1853','Cliente 853');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1362,'1854','Cliente 854');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1363,'1855','Cliente 855');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1364,'1856','Cliente 856');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1365,'1857','Cliente 857');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1366,'1858','Cliente 858');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1367,'1859','Cliente 859');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1368,'1860','Cliente 860');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1369,'1861','Cliente 861');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1370,'1862','Cliente 862');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1371,'1863','Cliente 863');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1372,'1864','Cliente 864');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1373,'1865','Cliente 865');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1374,'1866','Cliente 866');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1375,'1867','Cliente 867');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1376,'1868','Cliente 868');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1377,'1869','Cliente 869');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1378,'1870','Cliente 870');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1379,'1871','Cliente 871');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1380,'1872','Cliente 872');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1381,'1873','Cliente 873');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1382,'1874','Cliente 874');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1383,'1875','Cliente 875');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1384,'1876','Cliente 876');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1385,'1877','Cliente 877');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1386,'1878','Cliente 878');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1387,'1879','Cliente 879');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1388,'1880','Cliente 880');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1389,'1881','Cliente 881');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1390,'1882','Cliente 882');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1391,'1883','Cliente 883');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1392,'1884','Cliente 884');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1393,'1885','Cliente 885');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1394,'1886','Cliente 886');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1395,'1887','Cliente 887');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1396,'1888','Cliente 888');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1397,'1889','Cliente 889');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1398,'1890','Cliente 890');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1399,'1891','Cliente 891');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1400,'1892','Cliente 892');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1401,'1893','Cliente 893');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1402,'1894','Cliente 894');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1403,'1895','Cliente 895');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1404,'1896','Cliente 896');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1405,'1897','Cliente 897');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1406,'1898','Cliente 898');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1407,'1899','Cliente 899');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1408,'1900','Cliente 900');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1409,'1901','Cliente 901');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1410,'1902','Cliente 902');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1411,'1903','Cliente 903');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1412,'1904','Cliente 904');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1413,'1905','Cliente 905');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1414,'1906','Cliente 906');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1415,'1907','Cliente 907');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1416,'1908','Cliente 908');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1417,'1909','Cliente 909');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1418,'1910','Cliente 910');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1419,'1911','Cliente 911');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1420,'1912','Cliente 912');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1421,'1913','Cliente 913');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1422,'1914','Cliente 914');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1423,'1915','Cliente 915');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1424,'1916','Cliente 916');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1425,'1917','Cliente 917');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1426,'1918','Cliente 918');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1427,'1919','Cliente 919');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1428,'1920','Cliente 920');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1429,'1921','Cliente 921');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1430,'1922','Cliente 922');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1431,'1923','Cliente 923');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1432,'1924','Cliente 924');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1433,'1925','Cliente 925');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1434,'1926','Cliente 926');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1435,'1927','Cliente 927');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1436,'1928','Cliente 928');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1437,'1929','Cliente 929');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1438,'1930','Cliente 930');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1439,'1931','Cliente 931');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1440,'1932','Cliente 932');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1441,'1933','Cliente 933');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1442,'1934','Cliente 934');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1443,'1935','Cliente 935');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1444,'1936','Cliente 936');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1445,'1937','Cliente 937');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1446,'1938','Cliente 938');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1447,'1939','Cliente 939');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1448,'1940','Cliente 940');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1449,'1941','Cliente 941');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1450,'1942','Cliente 942');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1451,'1943','Cliente 943');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1452,'1944','Cliente 944');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1453,'1945','Cliente 945');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1454,'1946','Cliente 946');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1455,'1947','Cliente 947');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1456,'1948','Cliente 948');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1457,'1949','Cliente 949');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1458,'1950','Cliente 950');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1459,'1951','Cliente 951');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1460,'1952','Cliente 952');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1461,'1953','Cliente 953');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1462,'1954','Cliente 954');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1463,'1955','Cliente 955');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1464,'1956','Cliente 956');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1465,'1957','Cliente 957');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1466,'1958','Cliente 958');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1467,'1959','Cliente 959');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1468,'1960','Cliente 960');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1469,'1961','Cliente 961');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1470,'1962','Cliente 962');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1471,'1963','Cliente 963');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1472,'1964','Cliente 964');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1473,'1965','Cliente 965');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1474,'1966','Cliente 966');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1475,'1967','Cliente 967');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1476,'1968','Cliente 968');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1477,'1969','Cliente 969');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1478,'1970','Cliente 970');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1479,'1971','Cliente 971');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1480,'1972','Cliente 972');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1481,'1973','Cliente 973');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1482,'1974','Cliente 974');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1483,'1975','Cliente 975');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1484,'1976','Cliente 976');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1485,'1977','Cliente 977');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1486,'1978','Cliente 978');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1487,'1979','Cliente 979');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1488,'1980','Cliente 980');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1489,'1981','Cliente 981');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1490,'1982','Cliente 982');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1491,'1983','Cliente 983');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1492,'1984','Cliente 984');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1493,'1985','Cliente 985');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1494,'1986','Cliente 986');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1495,'1987','Cliente 987');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1496,'1988','Cliente 988');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1497,'1989','Cliente 989');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1498,'1990','Cliente 990');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1499,'1991','Cliente 991');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1500,'1992','Cliente 992');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1501,'1993','Cliente 993');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1502,'1994','Cliente 994');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1503,'1995','Cliente 995');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1504,'1996','Cliente 996');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1505,'1997','Cliente 997');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1506,'1998','Cliente 998');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1507,'1999','Cliente 999');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1508,'2000','Cliente 1000');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1509,'2001','Cliente 1001');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1510,'2002','Cliente 1002');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1511,'2003','Cliente 1003');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1512,'2004','Cliente 1004');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1513,'2005','Cliente 1005');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1514,'2006','Cliente 1006');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1515,'2007','Cliente 1007');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1516,'2008','Cliente 1008');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1517,'2009','Cliente 1009');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1518,'2010','Cliente 1010');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1519,'2011','Cliente 1011');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1520,'2012','Cliente 1012');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1521,'2013','Cliente 1013');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1522,'2014','Cliente 1014');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1523,'2015','Cliente 1015');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1524,'2016','Cliente 1016');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1525,'2017','Cliente 1017');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1526,'2018','Cliente 1018');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1527,'2019','Cliente 1019');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1528,'2020','Cliente 1020');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1529,'2021','Cliente 1021');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1530,'2022','Cliente 1022');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1531,'2023','Cliente 1023');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1532,'2024','Cliente 1024');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1533,'2025','Cliente 1025');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1534,'2026','Cliente 1026');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1535,'2027','Cliente 1027');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1536,'2028','Cliente 1028');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1537,'2029','Cliente 1029');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1538,'2030','Cliente 1030');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1539,'2031','Cliente 1031');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1540,'2032','Cliente 1032');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1541,'2033','Cliente 1033');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1542,'2034','Cliente 1034');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1543,'2035','Cliente 1035');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1544,'2036','Cliente 1036');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1545,'2037','Cliente 1037');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1546,'2038','Cliente 1038');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1547,'2039','Cliente 1039');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1548,'2040','Cliente 1040');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1549,'2041','Cliente 1041');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1550,'2042','Cliente 1042');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1551,'2043','Cliente 1043');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1552,'2044','Cliente 1044');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1553,'2045','Cliente 1045');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1554,'2046','Cliente 1046');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1555,'2047','Cliente 1047');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1556,'2048','Cliente 1048');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1557,'2049','Cliente 1049');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1558,'2050','Cliente 1050');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1559,'2051','Cliente 1051');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1560,'2052','Cliente 1052');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1561,'2053','Cliente 1053');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1562,'2054','Cliente 1054');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1563,'2055','Cliente 1055');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1564,'2056','Cliente 1056');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1565,'2057','Cliente 1057');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1566,'2058','Cliente 1058');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1567,'2059','Cliente 1059');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1568,'2060','Cliente 1060');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1569,'2061','Cliente 1061');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1570,'2062','Cliente 1062');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1571,'2063','Cliente 1063');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1572,'2064','Cliente 1064');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1573,'2065','Cliente 1065');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1574,'2066','Cliente 1066');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1575,'2067','Cliente 1067');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1576,'2068','Cliente 1068');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1577,'2069','Cliente 1069');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1578,'2070','Cliente 1070');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1579,'2071','Cliente 1071');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1580,'2072','Cliente 1072');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1581,'2073','Cliente 1073');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1582,'2074','Cliente 1074');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1583,'2075','Cliente 1075');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1584,'2076','Cliente 1076');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1585,'2077','Cliente 1077');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1586,'2078','Cliente 1078');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1587,'2079','Cliente 1079');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1588,'2080','Cliente 1080');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1589,'2081','Cliente 1081');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1590,'2082','Cliente 1082');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1591,'2083','Cliente 1083');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1592,'2084','Cliente 1084');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1593,'2085','Cliente 1085');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1594,'2086','Cliente 1086');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1595,'2087','Cliente 1087');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1596,'2088','Cliente 1088');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1597,'2089','Cliente 1089');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1598,'2090','Cliente 1090');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1599,'2091','Cliente 1091');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1600,'2092','Cliente 1092');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1601,'2093','Cliente 1093');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1602,'2094','Cliente 1094');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1603,'2095','Cliente 1095');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1604,'2096','Cliente 1096');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1605,'2097','Cliente 1097');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1606,'2098','Cliente 1098');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1607,'2099','Cliente 1099');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1608,'2100','Cliente 1100');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1609,'2101','Cliente 1101');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1610,'2102','Cliente 1102');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1611,'2103','Cliente 1103');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1612,'2104','Cliente 1104');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1613,'2105','Cliente 1105');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1614,'2106','Cliente 1106');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1615,'2107','Cliente 1107');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1616,'2108','Cliente 1108');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1617,'2109','Cliente 1109');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1618,'2110','Cliente 1110');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1619,'2111','Cliente 1111');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1620,'2112','Cliente 1112');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1621,'2113','Cliente 1113');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1622,'2114','Cliente 1114');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1623,'2115','Cliente 1115');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1624,'2116','Cliente 1116');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1625,'2117','Cliente 1117');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1626,'2118','Cliente 1118');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1627,'2119','Cliente 1119');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1628,'2120','Cliente 1120');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1629,'2121','Cliente 1121');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1630,'2122','Cliente 1122');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1631,'2123','Cliente 1123');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1632,'2124','Cliente 1124');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1633,'2125','Cliente 1125');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1634,'2126','Cliente 1126');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1635,'2127','Cliente 1127');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1636,'2128','Cliente 1128');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1637,'2129','Cliente 1129');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1638,'2130','Cliente 1130');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1639,'2131','Cliente 1131');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1640,'2132','Cliente 1132');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1641,'2133','Cliente 1133');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1642,'2134','Cliente 1134');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1643,'2135','Cliente 1135');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1644,'2136','Cliente 1136');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1645,'2137','Cliente 1137');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1646,'2138','Cliente 1138');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1647,'2139','Cliente 1139');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1648,'2140','Cliente 1140');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1649,'2141','Cliente 1141');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1650,'2142','Cliente 1142');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1651,'2143','Cliente 1143');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1652,'2144','Cliente 1144');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1653,'2145','Cliente 1145');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1654,'2146','Cliente 1146');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1655,'2147','Cliente 1147');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1656,'2148','Cliente 1148');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1657,'2149','Cliente 1149');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1658,'2150','Cliente 1150');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1659,'2151','Cliente 1151');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1660,'2152','Cliente 1152');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1661,'2153','Cliente 1153');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1662,'2154','Cliente 1154');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1663,'2155','Cliente 1155');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1664,'2156','Cliente 1156');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1665,'2157','Cliente 1157');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1666,'2158','Cliente 1158');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1667,'2159','Cliente 1159');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1668,'2160','Cliente 1160');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1669,'2161','Cliente 1161');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1670,'2162','Cliente 1162');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1671,'2163','Cliente 1163');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1672,'2164','Cliente 1164');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1673,'2165','Cliente 1165');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1674,'2166','Cliente 1166');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1675,'2167','Cliente 1167');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1676,'2168','Cliente 1168');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1677,'2169','Cliente 1169');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1678,'2170','Cliente 1170');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1679,'2171','Cliente 1171');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1680,'2172','Cliente 1172');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1681,'2173','Cliente 1173');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1682,'2174','Cliente 1174');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1683,'2175','Cliente 1175');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1684,'2176','Cliente 1176');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1685,'2177','Cliente 1177');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1686,'2178','Cliente 1178');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1687,'2179','Cliente 1179');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1688,'2180','Cliente 1180');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1689,'2181','Cliente 1181');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1690,'2182','Cliente 1182');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1691,'2183','Cliente 1183');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1692,'2184','Cliente 1184');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1693,'2185','Cliente 1185');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1694,'2186','Cliente 1186');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1695,'2187','Cliente 1187');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1696,'2188','Cliente 1188');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1697,'2189','Cliente 1189');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1698,'2190','Cliente 1190');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1699,'2191','Cliente 1191');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1700,'2192','Cliente 1192');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1701,'2193','Cliente 1193');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1702,'2194','Cliente 1194');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1703,'2195','Cliente 1195');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1704,'2196','Cliente 1196');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1705,'2197','Cliente 1197');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1706,'2198','Cliente 1198');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1707,'2199','Cliente 1199');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1708,'2200','Cliente 1200');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1709,'2201','Cliente 1201');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1710,'2202','Cliente 1202');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1711,'2203','Cliente 1203');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1712,'2204','Cliente 1204');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1713,'2205','Cliente 1205');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1714,'2206','Cliente 1206');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1715,'2207','Cliente 1207');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1716,'2208','Cliente 1208');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1717,'2209','Cliente 1209');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1718,'2210','Cliente 1210');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1719,'2211','Cliente 1211');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1720,'2212','Cliente 1212');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1721,'2213','Cliente 1213');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1722,'2214','Cliente 1214');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1723,'2215','Cliente 1215');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1724,'2216','Cliente 1216');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1725,'2217','Cliente 1217');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1726,'2218','Cliente 1218');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1727,'2219','Cliente 1219');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1728,'111','clieten111');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1729,'222','cliente222');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1764,'1010','Cliente de Prueba 1');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1765,'1111','Cliente de Prueba 2');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1766,'1214','Cliente de Prueba 3');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1767,'1216','Cliente de Prueba 4');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1768,'1220','Cliente de Prueba 5');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1769,'1222','Cliente de Prueba 6');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1770,'1224','Cliente de Prueba 7');
insert  into `tbl_cliente`(`ID`,`Codigo`,`Cliente`) values (1771,'1226','Cliente de Prueba 8');

/*Table structure for table `tbl_comercial` */

DROP TABLE IF EXISTS `tbl_comercial`;

CREATE TABLE `tbl_comercial` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `ID_Cliente` bigint(20) DEFAULT NULL,
  `ID_Productor` bigint(20) DEFAULT NULL,
  `ID_Especie` bigint(20) DEFAULT NULL,
  `ID_Tipo` bigint(20) DEFAULT NULL,
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
  `usuario` varchar(15) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_comercial` */

insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (1,6,1,1,1,1,1,'1000.000','100.000','900.000',50,'GQ123','2018-12-24T19:12:13',NULL,'1','53','');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (2,6,1,1,2,1,1,'1000.000','50.000','950.000',50,'GS123','2018-12-24T19:14:37',NULL,'1','53','');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (3,6,1,1,1,1,1,'100.000','60.000','40.000',10,'FC0044','2018-12-27T01:30:39',NULL,'1','54','');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (4,6,1,2,1,1,1,'121.000','21.160','99.840',10,'11','2019-01-03T13:31:44',NULL,'0','35','');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (5,6,1,2,1,2,1,'122.000','24.060','97.940',11,'22','2019-01-03T13:32:42',NULL,'0','35','');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (6,6,2,6,2,1,1,'1211.000','75.160','1135.840',40,'FC11','2019-01-04T00:14:08',NULL,'0','24','');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (7,6,1,6,1,1,1,'100.000','21.160','78.840',10,'fcgt555','2019-01-05T01:20:35',NULL,'0','38','');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (8,6,1,6,1,1,1,'322.000','93.160','228.840',50,'fcg555','2019-01-05T01:20:51',NULL,'0','39','');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (9,6,1,6,1,2,1,'422.000','234.960','187.040',122,'de333','2019-01-05T01:21:05',NULL,'0','37','');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (10,6,1,6,2,1,1,'121.000','222.760','-101.760',122,'121','2019-01-05T01:21:54',NULL,'0','36','');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (11,6,1,6,2,1,1,'1233.000','22162.960','-20929.960',12311,'gff','2019-01-05T01:30:08',NULL,'0','40','');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (12,6,2,6,1,1,1,'10011.000','21.160','9989.840',10,'Fc001','2019-01-08T12:53:12',NULL,'0',NULL,'');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (13,7,4,2,1,1,1,'123.330','21.160','102.170',10,'33','2019-01-08T13:02:09',NULL,'0',NULL,'');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (14,6,1,6,1,2,1,'123.340','193.160','-69.820',100,'FC786','2019-01-09T12:04:40','2019-01-09 12:04:40','0','43','');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (15,6,1,6,1,1,1,'222.200','219.160','3.040',120,'FC6544','2019-01-09T12:05:38','2019-01-09 12:05:38','0','35','');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (16,6,1,6,1,1,2,'12231.000','226.100','12004.900',123,'FC655','2019-01-09T15:41:06','2019-01-09 15:41:06','0',NULL,'');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (17,6,1,6,1,1,1,'123.000','224.560','-101.560',123,'fc003','2019-01-09T15:41:26','2019-01-09 15:41:26','0',NULL,'');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (18,6,1,1,1,1,2,'123.000','26.300','96.700',12,'fc010','2019-01-17T16:07:27','2019-01-17 16:07:27','0',NULL,'diegocade');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (19,6,1,1,1,3,2,'412.000','40.442','371.558',21,'fc011','2019-01-17T16:07:55','2019-01-17 16:07:55','0',NULL,'diegocade');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (20,6,1,8,1,1,1,'12.000','6.760','5.240',2,'fc555','2019-01-23T11:08:36','2019-01-23 11:08:36','0','42','diegocade');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (21,6,1,6,1,1,1,'123.000','24.760','98.240',12,'asd1','2019-01-30T16:15:56','2019-01-30 16:15:56','0',NULL,'usuario');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (22,6,1,6,2,1,1,'100.000','21.160','78.840',10,'FC077','2019-02-04T10:44:46','2019-02-04 10:44:48','0','42','usuario');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (23,7,4,6,1,1,1,'250.000','93.160','156.840',50,'FC087','2019-02-04T10:46:44','2019-02-04 10:46:45','0',NULL,'usuario');
insert  into `tbl_comercial`(`ID`,`ID_Cliente`,`ID_Productor`,`ID_Especie`,`ID_Tipo`,`ID_Bandeja`,`ID_Pallet`,`kilos_Brutos`,`tara`,`kilos_netos`,`cantidad_bandejas`,`folio`,`fecha`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (24,7,4,6,1,1,1,'260.000','93.160','166.840',50,'FC0923','2019-02-04T10:47:26','2019-02-04 10:47:26','0',NULL,'usuario');

/*Table structure for table `tbl_correlativo` */

DROP TABLE IF EXISTS `tbl_correlativo`;

CREATE TABLE `tbl_correlativo` (
  `Proceso` varchar(50) NOT NULL,
  `SubProceso` varchar(50) NOT NULL,
  `correlativo_disponible` bigint(20) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `tbl_correlativo` */

insert  into `tbl_correlativo`(`Proceso`,`SubProceso`,`correlativo_disponible`) values ('Recepcion','Recepcion',43);
insert  into `tbl_correlativo`(`Proceso`,`SubProceso`,`correlativo_disponible`) values ('sublote','sublote',10);

/*Table structure for table `tbl_destinorecepcion` */

DROP TABLE IF EXISTS `tbl_destinorecepcion`;

CREATE TABLE `tbl_destinorecepcion` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_destinorecepcion` */

insert  into `tbl_destinorecepcion`(`ID`,`Descripcion`) values (1,'Packing');
insert  into `tbl_destinorecepcion`(`ID`,`Descripcion`) values (2,'Congelado');

/*Table structure for table `tbl_embalaje` */

DROP TABLE IF EXISTS `tbl_embalaje`;

CREATE TABLE `tbl_embalaje` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50) DEFAULT NULL,
  `peso` decimal(10,3) DEFAULT NULL,
  `potes` int(11) DEFAULT NULL,
  `ID_cliente` bigint(20) NOT NULL,
  UNIQUE KEY `codigo` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_embalaje` */

insert  into `tbl_embalaje`(`ID`,`descripcion`,`peso`,`potes`,`ID_cliente`) values (1,'1.1','10.000',4,6);
insert  into `tbl_embalaje`(`ID`,`descripcion`,`peso`,`potes`,`ID_cliente`) values (2,'2.2','11.000',35,7);
insert  into `tbl_embalaje`(`ID`,`descripcion`,`peso`,`potes`,`ID_cliente`) values (3,'3.3','10.000',50,6);
insert  into `tbl_embalaje`(`ID`,`descripcion`,`peso`,`potes`,`ID_cliente`) values (4,'4.4','20.000',40,7);
insert  into `tbl_embalaje`(`ID`,`descripcion`,`peso`,`potes`,`ID_cliente`) values (5,'5.5','11.000',30,6);
insert  into `tbl_embalaje`(`ID`,`descripcion`,`peso`,`potes`,`ID_cliente`) values (6,'1.1.1','12.000',13,509);

/*Table structure for table `tbl_especie` */

DROP TABLE IF EXISTS `tbl_especie`;

CREATE TABLE `tbl_especie` (
  `ID_especie` bigint(20) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(50) NOT NULL,
  `fecha_uso` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID_especie`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_especie` */

insert  into `tbl_especie`(`ID_especie`,`Descripcion`,`fecha_uso`) values (1,'Arandano','2019-01-03 22:56:53');
insert  into `tbl_especie`(`ID_especie`,`Descripcion`,`fecha_uso`) values (2,'Cereza','2018-12-26 17:21:19');
insert  into `tbl_especie`(`ID_especie`,`Descripcion`,`fecha_uso`) values (3,'Melon','2018-11-19 13:46:00');
insert  into `tbl_especie`(`ID_especie`,`Descripcion`,`fecha_uso`) values (4,'Durazno','2018-11-19 13:46:56');
insert  into `tbl_especie`(`ID_especie`,`Descripcion`,`fecha_uso`) values (5,'Frutilla','2018-11-19 13:47:00');
insert  into `tbl_especie`(`ID_especie`,`Descripcion`,`fecha_uso`) values (6,'Manzana','2019-02-13 16:57:57');
insert  into `tbl_especie`(`ID_especie`,`Descripcion`,`fecha_uso`) values (7,'Especie de Prueba 1','2019-01-17 17:22:58');
insert  into `tbl_especie`(`ID_especie`,`Descripcion`,`fecha_uso`) values (8,'Especie de Prueba 2','2019-01-30 13:56:27');
insert  into `tbl_especie`(`ID_especie`,`Descripcion`,`fecha_uso`) values (9,'Especie de Prueba 3','2019-01-17 17:23:00');
insert  into `tbl_especie`(`ID_especie`,`Descripcion`,`fecha_uso`) values (10,'Especie de Prueba 4','2019-01-17 17:23:00');
insert  into `tbl_especie`(`ID_especie`,`Descripcion`,`fecha_uso`) values (11,'Especie de Prueba 5','2019-01-17 17:23:00');
insert  into `tbl_especie`(`ID_especie`,`Descripcion`,`fecha_uso`) values (12,'Especie de Prueba 6','2019-01-17 17:23:00');
insert  into `tbl_especie`(`ID_especie`,`Descripcion`,`fecha_uso`) values (13,'Especie de Prueba 7','2019-01-17 17:23:00');
insert  into `tbl_especie`(`ID_especie`,`Descripcion`,`fecha_uso`) values (14,'Especie de Prueba 8','2019-01-30 11:45:11');

/*Table structure for table `tbl_etiqueta` */

DROP TABLE IF EXISTS `tbl_etiqueta`;

CREATE TABLE `tbl_etiqueta` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(50) DEFAULT NULL,
  `ID_especie` bigint(20) DEFAULT NULL,
  `ID_cliente` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_etiqueta` */

insert  into `tbl_etiqueta`(`ID`,`Descripcion`,`ID_especie`,`ID_cliente`) values (1,'Berry Fresh 1',6,6);
insert  into `tbl_etiqueta`(`ID`,`Descripcion`,`ID_especie`,`ID_cliente`) values (2,'Berry Fresh 2',2,7);
insert  into `tbl_etiqueta`(`ID`,`Descripcion`,`ID_especie`,`ID_cliente`) values (3,'Berry Fresh 3',1,6);

/*Table structure for table `tbl_exportacion` */

DROP TABLE IF EXISTS `tbl_exportacion`;

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
  `usuario` varchar(15) NOT NULL DEFAULT ' ',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=77 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_exportacion` */

insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (1,6,6,2,1,1,2,'FC001',1,1,'-2025',10,'1','2018-12-05 12:18:59',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (2,6,6,2,1,1,2,'FC001',2,2,'-2025',50,'400','2018-12-05 12:19:17',0,'24',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (3,6,6,2,1,1,2,'FC001',2,2,'-2025',121,'122','2018-12-05 12:19:27',0,'24',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (4,6,6,2,1,1,1,'FC001',1,1,'-2025',10,'1001','2018-12-05 12:21:44',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (5,6,6,2,1,1,1,'FC001',2,1,'-2025',20,'2001','2018-12-05 12:21:44',0,'24',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (6,6,6,2,1,1,1,'FC001',3,2,'-2025',30,'3001','2018-12-05 12:21:44',0,'24',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (7,6,6,2,1,1,1,'FC001',1,1,'-2025',10,'1001','2018-12-05 12:24:07',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (8,6,6,2,1,1,1,'FC001',2,1,'-2025',20,'2001','2018-12-05 12:24:08',0,'24',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (9,6,6,2,1,1,1,'FC001',3,2,'-2025',30,'3001','2018-12-05 12:24:08',0,'24',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (10,6,6,2,1,1,1,'FC001',1,1,'-2025',10,'1001','2018-12-05 12:24:54',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (11,6,6,2,1,1,1,'FC001',2,1,'-2025',20,'2001','2018-12-05 12:24:55',0,'24',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (12,6,6,2,1,1,1,'FC001',3,2,'-2025',30,'3001','2018-12-05 12:24:55',0,'24',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (13,6,6,1,1,1,1,'FC001',1,1,'-2025',10,'1001','2018-12-05 12:30:08',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (14,6,6,1,1,1,1,'FC001',1,2,'-2025',20,'1002','2018-12-05 12:30:09',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (15,6,6,1,1,1,1,'FC001',1,2,'-2025',30,'1003','2018-12-05 12:30:09',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (16,6,6,1,1,1,1,'FC001',1,1,'-2025',10,'1001','2018-12-05 12:30:29',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (17,6,6,1,1,1,1,'FC001',1,2,'-2025',20,'1002','2018-12-05 12:30:29',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (18,6,6,1,1,1,1,'FC001',1,2,'-2025',30,'1003','2018-12-05 12:30:29',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (19,6,6,1,1,1,1,'FC001',1,1,'-2025',10,'1001','2018-12-05 12:31:55',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (20,6,6,1,1,1,1,'FC001',1,2,'-2025',20,'1002','2018-12-05 12:31:55',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (21,6,6,1,1,1,1,'FC001',1,2,'-2025',30,'1003','2018-12-05 12:31:55',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (22,6,6,1,1,1,1,'FC001',1,1,'-2025',11,'11','2018-12-05 12:34:08',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (23,6,6,1,2,1,1,'1211',2,1,'-2025',1231,'112','2018-12-05 15:36:21',0,'19',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (24,6,6,1,2,1,1,'1211',2,1,'-2025',121,'122','2018-12-05 15:36:21',0,'19',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (25,6,6,1,2,1,1,'1211',2,1,'-2025',1231,'112','2018-12-05 15:38:48',0,'19',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (26,6,6,1,2,1,1,'1211',2,1,'-2025',121,'122','2018-12-05 15:38:49',0,'19',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (27,6,6,1,2,1,1,'1211',2,1,'-2025',1231,'112','2018-12-05 15:39:19',0,'19',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (28,6,6,1,2,1,1,'1211',2,1,'-2025',121,'122','2018-12-05 15:39:20',0,'19',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (29,6,6,2,1,1,1,'FC001',1,1,'-2025',100,'12','2018-12-05 15:43:33',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (30,6,6,2,1,1,1,'FC001',1,1,'-2025',33,'21','2018-12-05 15:43:33',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (31,6,6,2,1,1,1,'FC001',1,1,'-2025',121,'211','2018-12-05 15:43:34',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (32,7,6,1,2,1,1,'fc005',4,1,'-2025',10212,'122','2018-12-05 15:46:44',0,'18',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (33,7,6,1,2,1,1,'fc005',4,1,'-2025',2333,'554','2018-12-05 15:46:45',0,'18',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (34,7,6,1,2,1,1,'fc005',4,1,'-2025',668,'566','2018-12-05 15:46:46',0,'18',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (35,6,6,1,1,1,2,'FC001',1,1,'-2025',30,'432','2018-12-05 15:51:12',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (36,6,6,1,1,1,2,'FC001',1,1,'-2025',1221,'432','2018-12-05 15:51:12',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (37,6,6,1,1,1,2,'FC001',1,1,'-2025',1211,'5454','2018-12-05 15:51:12',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (38,6,6,1,1,1,2,'FC001',1,1,'-2025',1,'1','2018-12-05 15:51:13',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (39,6,6,1,1,1,2,'FC001',1,1,'-2025',2,'2','2018-12-05 15:51:14',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (40,6,6,1,1,1,2,'FC001',1,1,'-2025',3,'3','2018-12-05 15:51:15',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (41,6,6,1,1,1,2,'FC001',1,1,'-2025',4,'4','2018-12-05 15:51:15',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (42,6,6,1,1,1,2,'FC001',1,1,'-2025',5,'5','2018-12-05 15:51:15',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (43,6,6,1,1,1,2,'FC001',1,1,'-2025',66,'6','2018-12-05 15:51:15',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (44,6,6,1,1,1,2,'FC001',1,1,'-2025',7,'7','2018-12-05 15:51:15',1,'53',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (45,7,6,1,1,1,1,'FC001',4,1,'-2025',1,'1','2018-12-05 15:59:12',0,'24',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (46,7,6,1,1,1,1,'FC001',4,1,'-2025',2,'2','2018-12-05 15:59:13',0,'24',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (47,7,6,1,1,1,1,'FC001',4,1,'-2025',3,'3','2018-12-05 15:59:14',0,'24',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (48,7,6,1,1,1,1,'FC001',4,1,'-2025',4,'4','2018-12-05 15:59:14',0,'24',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (49,7,6,1,1,1,1,'FC001',4,1,'-2025',5,'5','2018-12-05 15:59:14',0,'24',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (50,7,6,1,1,1,1,'FC001',4,1,'-2025',6,'6','2018-12-05 15:59:15',0,'24',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (51,7,6,1,1,1,1,'FC001',4,1,'-2025',7,'7','2018-12-05 15:59:16',0,'24',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (52,7,6,1,1,1,1,'FC001',4,1,'-2025',8,'8','2018-12-05 15:59:16',0,'24',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (53,7,6,1,1,1,1,'FC001',4,1,'-2025',9,'9','2018-12-05 15:59:16',0,'24',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (54,7,6,1,1,1,1,'FC001',4,1,'-2025',10,'10','2018-12-05 15:59:16',0,'24',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (55,7,6,1,1,1,1,'FA001',4,1,'-2024',50,'121','2018-12-06 16:36:03',0,'16',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (56,7,6,1,1,1,1,'FA001',4,2,'-2024',30,'332','2018-12-06 16:36:03',0,'16',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (57,7,6,1,1,1,1,'FA001',4,2,'-2024',121,'2211','2018-12-06 16:36:04',0,'16',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (58,6,2,1,1,1,1,'FC9765',1,1,'-2000',30,'32','2018-12-30 01:34:58',0,'37',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (59,6,2,1,1,1,1,'FC9765',1,1,'-2000',122,'43','2018-12-30 01:34:58',0,'37',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (60,6,6,1,1,1,1,'FC002',1,1,'-2016',12,'12','2019-01-04 00:13:26',1,'54',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (61,6,6,1,1,1,1,'FC002',1,1,'-2016',33,'12','2019-01-04 00:13:26',1,'54',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (62,6,6,1,1,1,1,'fc004',2,1,'2008',12,'123','2019-01-10 11:46:42',0,NULL,' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (63,6,6,1,1,1,1,'fc006',2,2,'2008',1,'','2019-01-10 11:53:59',0,NULL,' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (64,6,6,1,1,1,1,'fc007',1,2,'2008',1,'','2019-01-10 11:54:54',0,'38',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (65,6,6,1,1,1,1,'fc007',2,2,'2008',1,'','2019-01-10 11:55:01',0,NULL,' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (66,6,6,1,1,1,1,'fc008',1,2,'2008',1,'','2019-01-10 11:56:01',0,'36',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (67,6,6,1,1,1,1,'fc008',2,2,'2008',1,'','2019-01-10 11:56:03',0,NULL,' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (68,6,6,1,1,1,1,'12123',1,1,'2010',12,'12','2019-01-10 14:58:17',0,'39',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (69,6,6,1,1,1,1,'12124',1,1,'2010',12,'12','2019-01-10 14:59:48',0,'48',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (70,6,6,1,1,1,1,'12125',1,1,'2008',12,'12','2019-01-10 15:00:09',0,NULL,' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (71,6,6,1,1,2,2,'123124',1,2,'10-01-2019',12,'12','2019-01-10 15:07:08',0,'42',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (72,6,6,1,1,2,2,'123125',1,2,'10-01-2019',12,'12','2019-01-10 15:10:35',0,'40',' ');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (73,7,6,2,2,1,2,'fc009',5,1,'17-01-2019',11,'','2019-01-17 16:05:34',0,NULL,'diegocade');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (74,7,9,2,2,1,1,'fc444',4,1,'23-01-2019',12,'1232','2019-01-23 11:07:38',0,NULL,'diegocade');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (75,7,9,2,2,1,1,'fc444',5,3,'23-01-2019',23,'13432','2019-01-23 11:07:43',0,NULL,'diegocade');
insert  into `tbl_exportacion`(`ID`,`ID_Cliente`,`ID_Especie`,`ID_Embalaje`,`ID_Etiqueta`,`ID_TipoArmado`,`ID_TipoMercado`,`Folio`,`ID_Productor`,`ID_Variedad`,`fecha`,`cantidad_cajas`,`documento`,`fecha_sistema`,`estado`,`Maquila`,`usuario`) values (76,6,14,1,1,1,1,'122412',1,1,'30-01-2019',12,'','2019-01-30 10:09:31',0,'43','usuario');

/*Table structure for table `tbl_maquila` */

DROP TABLE IF EXISTS `tbl_maquila`;

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
  `usuario` varchar(15) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=55 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_maquila` */

insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (1,'6','1',1,'555','2018-12-29 20:13:06','2018-12-29 20:06:40','12311',6,'2018-12-29 20:06:47.666','2018-12-29 20:06:49.054','80','0.000','0.000','0.000',NULL,'');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (2,'6','1',1,'123','2019-01-01 01:25:16','2019-01-01 01:24:16','1232',1,'2019-01-01 01:24:13.754','2019-01-01 01:24:15.051','50','0.000','0.000','0.000',NULL,'');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (3,'6','1',1,'1231','2019-01-01 02:38:06','2019-01-01 02:37:00','5442',1,'2019-01-01 02:36:56.898','2019-01-01 02:37:04.186','99','0.000','0.000','0.000',NULL,'');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (4,'6','1',1,'1231','2019-01-01 02:42:34','2019-01-01 02:42:12','1221',1,'2019-01-01 02:42:10.911','2019-01-01 02:42:11.288','99','0.000','0.000','0.000',NULL,'');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (5,'6','1',1,'123','2019-01-01 02:47:34','2019-01-01 02:47:14','12',3,'2019-01-01 02:47:17.108','2019-01-01 02:47:19.228','77','0.000','0.000','0.000',NULL,'');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (6,'6','1',1,'123','2019-01-01 02:52:56','2019-01-01 02:52:31','1231',3,'2019-01-01 02:52:37.613','2019-01-01 02:52:38.045','77','0.000','0.000','0.000',NULL,'');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (7,'6','1',1,'1211','2019-01-02 01:06:23','2019-01-02 01:06:01','1211',1,'2019-01-02 01:05:57.271','2019-01-02 01:05:58.036','122','0.000','0.000','0.000',NULL,'');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (8,'6','1',1,'1221','2019-01-02 01:07:47','2019-01-02 01:07:30','3221',21,'2019-01-02 01:07:25.172','2019-01-02 01:07:25.589','12','0.000','0.000','0.000',NULL,'');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (9,'6','1',1,'1221','2019-01-02 01:09:11','2019-01-02 01:07:30','3221',21,'2019-01-02 01:07:25.172','2019-01-02 01:07:25.589','12','0.000','0.000','0.000',NULL,'');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (10,'6','1',1,'1221','2019-01-02 01:09:37','2019-01-02 01:07:30','3221',21,'2019-01-02 01:07:25.172','2019-01-02 01:07:25.589','12','0.000','0.000','0.000',NULL,'');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (11,'6','1',1,'1221','2019-01-02 01:10:31','2019-01-02 01:07:30','3221',21,'2019-01-02 01:07:25.172','2019-01-02 01:07:25.589','12','0.000','0.000','0.000',NULL,'');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (12,'6','1',1,'1211','2019-01-02 22:37:06','2019-01-02 22:36:42','6655',1231,'2019-01-02 22:36:49.496','2019-01-02 22:36:50.336','65','0.000','0.000','0.000',NULL,'');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (13,'6','1',1,'444','2019-01-02 22:42:33','2019-01-02 22:42:23','22',33,'2019-01-02 22:42:28.099','2019-01-02 22:42:28.431','12','0.000','0.000','0.000',NULL,'');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (14,'6','1',1,'1231','2019-01-03 12:19:36','2019-01-03 12:19:25','213',12,'2019-01-03 12:18:29.664','2019-01-03 12:18:30.046','12','0.000','0.000','0.000',NULL,'');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (15,'6','1',1,'1231','2019-01-03 12:21:55','2019-01-03 12:19:25','213',12,'2019-01-03 12:18:29.664','2019-01-03 12:18:30.046','12','0.000','0.000','0.000',NULL,'');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (16,'6','1',1,'121','2019-01-04 00:16:14','2019-01-04 00:16:05','',2,'2019-01-04 00:16:01.510','2019-01-04 00:16:02.009','12','0.000','0.000','0.000',NULL,'');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (17,'6','1',1,'121','2019-01-04 13:27:15','2019-01-04 13:24:47','',2,'2019-01-04 13:24:52.203','2019-01-04 00:24:52 ','12','0.000','0.000','0.000',NULL,'');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (18,'6','1',1,'1231','2019-01-04 13:31:46','2019-01-04 13:31:29','',1,'2019-01-04 13:31:25.759','2019-01-04 13:31:26.224','10','0.000','0.000','0.000',NULL,'');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (19,'6','1',1,'121','2019-01-06 01:51:10','2019-01-06 01:50:18','1221',3,'2019-01-06 01:50:11.077','2019-01-06 01:50:11.595','211','12410.000','900.000','950.000','103.000','');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (20,'6','1',1,'11','2019-01-06 01:58:32','2019-01-06 01:58:28','32',1,'2019-01-06 01:58:22.740','2019-01-06 01:58:23.258','1','100.000','900.000','950.000','100.000','');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (21,'6','1',1,'121','2019-01-06 02:06:37','2019-01-06 02:05:58','122',1,'2019-01-06 02:06:01.088','2019-01-06 02:06:02.245','122','100.000','900.000','950.000','100.000','');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (22,'6','1',1,'12','2019-01-06 02:33:41','2019-01-06 02:33:20','322',2,'2019-01-06 02:33:14.559','2019-01-06 02:33:22.822','121','100.000','900.000','950.000','100.000','');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (23,'6','1',1,'12','2019-01-06 02:36:48','2019-01-06 02:33:20','322',2,'2019-01-06 02:33:14.559','2019-01-06 02:33:22.822','121','100.000','1097.780','848.240','100.000','');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (24,'6','1',1,'12','2019-01-06 02:40:15','2019-01-06 02:33:20','322',2,'2019-01-06 02:33:14.559','2019-01-06 02:33:22.822','121','100.000','1097.780','-18945.880','100.000','');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (25,'6','1',1,'122','2019-01-07 11:59:08','2019-01-07 11:55:56','22',1,'2019-01-07 11:55:51.425','2019-01-07 11:55:51.967','12','100.000','0.000','950.000','75.240','');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (26,'6','1',1,'12','2019-01-07 12:06:01','2019-01-07 12:04:39','121',2,'2019-01-07 12:04:36.205','2019-01-07 12:04:36.655','33','100.000','900.000','950.000','75.240','');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (27,'6','1',1,'111','2019-01-07 12:13:40','2019-01-07 12:13:06','1211',1,'2019-01-07 12:13:11.074','2019-01-07 12:13:11.625','211','100.000','900.000','950.000','75.240','');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (28,'6','1',1,'11','2019-01-07 12:28:42','2019-01-07 12:27:52','32',1,'2019-01-07 12:27:55.794','2019-01-07 12:27:56.253','11','100.000','0.000','950.000','75.240','');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (29,'6','1',1,'1211','2019-01-07 12:41:47','2019-01-07 12:38:23','1211',1,'2019-01-07 12:38:19.161','2019-01-07 12:38:20.069','211','400.000','900.000','950.000','75.240','');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (30,'6','1',1,'1211','2019-01-07 12:43:26','2019-01-07 12:38:23','1211',1,'2019-01-07 12:38:19.161','2019-01-07 12:38:20.069','211','400.000','900.000','950.000','71.280','');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (31,'6','1',1,'12','2019-01-09 11:47:27','2019-01-09 11:47:11','1222',2,'2019-01-09 11:43:01.913','2019-01-09 11:43:02.947','12','220.000','900.000','950.000','75.240','');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (32,'6','1',1,'12','2019-01-09 11:49:56','2019-01-09 11:47:11','1222',2,'2019-01-09 11:43:01.913','2019-01-09 11:43:02.947','12','220.000','1097.780','848.240','59.714','');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (33,'6','1',1,'12','2019-01-09 11:50:48','2019-01-09 11:47:11','1222',2,'2019-01-09 11:43:01.913','2019-01-09 11:43:02.947','12','220.000','1097.780','848.240','59.714','');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (34,'6','1',1,'1231','2019-01-09 15:38:37','2019-01-09 15:36:02','121',2,'2019-01-09 15:38:31.327','2019-01-09 15:38:31.775','11','220.000','1100.820','950.000','66.520','');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (35,'6','1',1,'1231','2019-01-09 15:39:20','2019-01-09 15:36:02','121',2,'2019-01-09 15:38:31.327','2019-01-09 15:38:31.775','11','220.000','1100.820','950.000','66.520','');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (36,'6','1',1,'121213','2019-01-10 17:13:19','2019-01-10 17:06:31','1242',1,'2019-01-10 17:06:31.655','2019-01-10 17:06:32.229','23','10.000','0.000','-101.760','-6.806','');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (37,'6','1',1,'211231','2019-01-10 17:17:26','2019-01-10 17:16:23','131312',1,'2019-01-10 17:16:18.898','2019-01-10 17:16:19.279','12','300.000','187.040','0.000','-8.300','');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (38,'6','1',1,'1231','2019-01-10 17:23:11','2019-01-10 17:22:30','13414',1,'2019-01-10 17:22:28.985','2019-01-10 17:22:29.441','131','10.000','78.840','0.000','-7.160','');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (39,'6','1',1,'556','2019-01-10 17:41:06','2019-01-10 17:39:50','12',1,'2019-01-10 17:39:44.266','2019-01-10 17:39:44.751','23','120.000','228.840','0.000','-8.000','');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (40,'6','1',1,'12321','2019-01-17 16:10:36','2019-01-17 16:08:49','41',1,'2019-01-17 16:08:43.181','2019-01-17 16:08:43.542','12','120.000','0.000','-20929.960','12284.700','diegocade');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (41,'6','1',16,'123','2019-02-07 17:32:18','2019-02-07 17:29:35','123',1,'2019-02-07 17:29:37.349','2019-02-07 17:50:38 ','20','120.000','5.240','0.000','-75.240','usuario');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (42,'6','1',16,'123','2019-02-07 17:46:56','2019-02-07 17:44:20','1211',1,'2019-02-07 17:44:21.838','2019-02-07 17:44:23.025','11','120.000','5.240','78.840','-75.240','usuario');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (43,'6','1',16,'123','2019-02-07 23:56:20','2019-02-07 23:44:19','12',1,'2019-02-07 23:44:21.512','2019-02-07 23:44:22.629','56','120.000','-69.820','0.000','-75.240','usuario');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (44,'6','1',14,'655','2019-02-08 13:07:36','2019-02-08 12:37:08','1222',1,'2019-02-08 12:37:09.826','2019-02-08 12:37:10.637','12','120.000','40.000','0.000','-8500.300','usuario');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (45,'6','1',14,'655','2019-02-08 13:16:43','2019-02-08 13:16:17','11',1,'2019-02-08 13:16:19.674','2019-02-08 13:16:20.765','19','120.000','40.000','0.000','-8500.300','usuario');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (46,'6','1',14,'655','2019-02-08 13:33:39','2019-02-08 13:33:11','111',1,'2019-02-08 13:33:12.118','2019-02-08 13:33:12.583','12','120.000','40.000','0.000','-8500.300','usuario');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (47,'6','1',14,'655','2019-02-08 13:39:58','2019-02-08 13:39:53','121',1,'2019-02-08 13:39:54.366','2019-02-08 13:39:55.079','12','120.000','40.000','0.000','-8500.300','usuario');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (48,'6','1',14,'655','2019-02-08 13:45:57','2019-02-08 13:45:20','122',1,'2019-02-08 01:45:21 ','2019-02-08 13:45:22.185','12','120.000','40.000','0.000','-8500.300','usuario');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (49,'6','1',16,'123','2019-02-11 13:40:10','2019-02-11 13:31:57','123',1,'2019-02-11 13:31:58.486','2019-02-11 13:31:59.554','12','100.000','0.000','950.000','75.240','usuario');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (50,'6','1',14,'655','2019-02-11 13:51:21','2019-02-11 13:50:32','1221',1,'2019-02-11 13:50:33.597','2019-02-11 13:50:34.131','12','100.000','900.000','950.000','790.080','usuario');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (51,'6','1',14,'655','2019-02-11 13:50:47','2019-02-11 14:02:16','12',1,'2019-02-11 14:02:17.050','2019-02-11 14:02:17.765','12','100.000','900.000','950.000','329.240','usuario');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (52,'6','1',14,'655','2019-02-11 13:57:28','2019-02-11 14:07:37','121',1,'2019-02-11 14:07:38.184','2019-02-11 14:07:38.763','213','120.000','40.000','0.000','8530.680','usuario');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (53,'6','1',14,'655','2019-02-11 14:14:41','2019-02-11 14:18:54','12',1,'2019-02-11 14:18:55.814','2019-02-11 14:18:56.696','45','100.000','900.000','950.000','8069.840','usuario');
insert  into `tbl_maquila`(`ID`,`ID_Cliente`,`ID_Productor`,`Lote`,`documento`,`fecha_sistema`,`fecha_recepcion`,`ordenEmbalaje`,`Linea`,`hora_Inicio`,`hora_Termino`,`rendimiento`,`kilos_exportacion`,`kilos_comerciales`,`kilos_merma`,`kilos_recepcion`,`usuario`) values (54,'6','1',14,'655','2019-02-11 14:18:43','2019-02-11 14:21:45','12',2,'2019-02-11 14:21:46.285','2019-02-11 14:21:46.912','32','120.000','40.000','0.000','111.240','usuario');

/*Table structure for table `tbl_pallet` */

DROP TABLE IF EXISTS `tbl_pallet`;

CREATE TABLE `tbl_pallet` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(50) NOT NULL,
  `Peso` decimal(5,3) NOT NULL DEFAULT '0.000',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_pallet` */

insert  into `tbl_pallet`(`ID`,`Descripcion`,`Peso`) values (1,'Madera','3.160');
insert  into `tbl_pallet`(`ID`,`Descripcion`,`Peso`) values (2,'Metal','4.700');
insert  into `tbl_pallet`(`ID`,`Descripcion`,`Peso`) values (3,'Plastico','2.077');

/*Table structure for table `tbl_permiso` */

DROP TABLE IF EXISTS `tbl_permiso`;

CREATE TABLE `tbl_permiso` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(25) NOT NULL,
  `llave` varchar(40) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `tbl_permiso` */

/*Table structure for table `tbl_prefijo` */

DROP TABLE IF EXISTS `tbl_prefijo`;

CREATE TABLE `tbl_prefijo` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Prefijo` varchar(6) DEFAULT NULL,
  `Estado` tinyint(4) DEFAULT '0',
  `fechaCreacion` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_prefijo` */

insert  into `tbl_prefijo`(`ID`,`Prefijo`,`Estado`,`fechaCreacion`) values (1,'PF',1,'2019-02-12 16:52:05');
insert  into `tbl_prefijo`(`ID`,`Prefijo`,`Estado`,`fechaCreacion`) values (2,'66',0,'2019-02-12 16:52:07');
insert  into `tbl_prefijo`(`ID`,`Prefijo`,`Estado`,`fechaCreacion`) values (3,'66',0,'2019-02-12 16:52:39');

/*Table structure for table `tbl_productor` */

DROP TABLE IF EXISTS `tbl_productor`;

CREATE TABLE `tbl_productor` (
  `codigo` bigint(20) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50) NOT NULL,
  `codigo_cliente` bigint(20) NOT NULL,
  `codigo_productor` varchar(30) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_productor` */

insert  into `tbl_productor`(`codigo`,`descripcion`,`codigo_cliente`,`codigo_productor`) values (1,'Productor1',6,'123');
insert  into `tbl_productor`(`codigo`,`descripcion`,`codigo_cliente`,`codigo_productor`) values (2,'productor2',6,'234');
insert  into `tbl_productor`(`codigo`,`descripcion`,`codigo_cliente`,`codigo_productor`) values (3,'productor3',6,'345');
insert  into `tbl_productor`(`codigo`,`descripcion`,`codigo_cliente`,`codigo_productor`) values (4,'productor4',7,'456');
insert  into `tbl_productor`(`codigo`,`descripcion`,`codigo_cliente`,`codigo_productor`) values (5,'productor5',7,'567');
insert  into `tbl_productor`(`codigo`,`descripcion`,`codigo_cliente`,`codigo_productor`) values (6,'productor6',511,'678');
insert  into `tbl_productor`(`codigo`,`descripcion`,`codigo_cliente`,`codigo_productor`) values (7,'productor7',511,'789');
insert  into `tbl_productor`(`codigo`,`descripcion`,`codigo_cliente`,`codigo_productor`) values (8,'productor8',512,'1123');
insert  into `tbl_productor`(`codigo`,`descripcion`,`codigo_cliente`,`codigo_productor`) values (9,'productor9',512,'2234');
insert  into `tbl_productor`(`codigo`,`descripcion`,`codigo_cliente`,`codigo_productor`) values (10,'productor10',513,'3345');
insert  into `tbl_productor`(`codigo`,`descripcion`,`codigo_cliente`,`codigo_productor`) values (11,'Productor de Prueba 1',6,'112');
insert  into `tbl_productor`(`codigo`,`descripcion`,`codigo_cliente`,`codigo_productor`) values (12,'Productor de Prueba 2',7,'222');
insert  into `tbl_productor`(`codigo`,`descripcion`,`codigo_cliente`,`codigo_productor`) values (13,'Productor de Prueba 3',509,'333');
insert  into `tbl_productor`(`codigo`,`descripcion`,`codigo_cliente`,`codigo_productor`) values (14,'Productor de Prueba 4',510,'444');
insert  into `tbl_productor`(`codigo`,`descripcion`,`codigo_cliente`,`codigo_productor`) values (15,'Productor de Prueba 5',511,'555');
insert  into `tbl_productor`(`codigo`,`descripcion`,`codigo_cliente`,`codigo_productor`) values (16,'Productor de Prueba 6',512,'666');
insert  into `tbl_productor`(`codigo`,`descripcion`,`codigo_cliente`,`codigo_productor`) values (17,'Productor de Prueba 7',513,'777');
insert  into `tbl_productor`(`codigo`,`descripcion`,`codigo_cliente`,`codigo_productor`) values (18,'Productor de Prueba 8',514,'889');

/*Table structure for table `tbl_recepcion` */

DROP TABLE IF EXISTS `tbl_recepcion`;

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
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_recepcion` */

insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (1,6,1,'Fulano','1125',1,1,'1.000',2,'2019-01-03 16:36:18','2019-01-03 16:37:22',12,0,4,0);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (2,6,1,'Fulano','1122',1,1,'1.000',1,'2019-01-03 16:49:41','2019-01-03 16:50:02',13,0,3,0);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (3,6,1,'huttt','655',1,1,'-87.000',1,'2019-01-03 22:49:15','2019-01-03 22:49:23',14,0,10,0);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (4,6,1,'hu','5433',6,1,'-55.000',1,'2019-01-03 23:24:17','2019-01-03 23:24:20',15,0,100,0);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (5,6,1,'121','123',6,1,'-122.000',1,'2019-01-04 00:12:37','2019-01-04 00:12:40',16,0,10,1);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (6,6,1,'fulano','1231',6,1,'1231.000',1,'2019-01-04 12:04:40','2019-01-04 12:04:41',17,0,10,0);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (7,6,1,'12311','12311',6,1,'12.000',1,'2019-01-05 01:36:00','2019-01-05 01:36:01',18,0,120,0);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (8,6,1,'fulano','33',1,1,'22.220',1,'2019-01-07 17:36:08','2019-01-07 17:36:09',19,0,11,0);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (9,6,1,'fulano','22',6,1,'12.000',2,'2019-01-07 17:41:04','2019-01-07 17:41:05',20,0,333,0);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (10,6,1,'Fulanito','121241223',6,1,'1.000',1,'2019-01-09 17:08:36','2019-01-09 17:08:36',24,0,12,0);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (11,6,1,'Fulano de tal','1123',6,1,'-2.500',1,'2019-01-10 15:54:22','2019-01-10 15:55:15',26,0,5,1);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (12,6,1,'FF','1123',6,1,'-2.500',1,'2019-01-10 16:05:44','2019-01-10 16:06:35',27,0,3,1);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (13,7,4,'Fulano de tal','1124',6,1,'-2.500',1,'2019-01-10 16:45:55','2019-01-10 16:46:08',28,0,3,1);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (14,6,1,'Fulano','fc002',6,1,'1.650',1,'2019-01-17 15:59:46','2019-01-17 15:59:46',29,0,3,1);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (15,6,1,'FUlano','1231123',8,1,'12.000',1,'2019-01-23 11:05:04','2019-01-23 11:05:04',30,0,2,2);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (16,6,1,'Fulanuto','22331144',6,1,'-1.300',1,'2019-01-30 11:12:51','2019-01-30 11:12:51',31,0,2,1);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (17,6,2,'Fasioas','1122',14,1,'-1.200',1,'2019-01-30 11:45:09','2019-01-30 11:45:10',32,0,2,1);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (18,6,1,'FUlano','1231122',8,1,'12.000',1,'2019-01-30 13:23:35','2019-01-30 13:23:44',33,0,2,2);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (19,6,1,'Fulano','00001',8,1,'1.000',1,'2019-01-30 13:44:59','2019-01-30 13:45:00',34,0,0,1);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (20,6,2,'Fulano','00001',8,1,'1.000',1,'2019-01-30 13:52:39','2019-01-30 13:52:39',35,0,3,1);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (21,7,4,'fulano','121',6,1,'-3.000',1,'2019-02-04 11:43:50','2019-02-04 11:43:51',36,0,10,1);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (22,7,4,'111','1211',6,1,'1.000',1,'2019-02-04 11:53:58','2019-02-04 11:53:59',37,0,12,1);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (23,7,4,'fulano','12112',6,1,'-4.000',1,'2019-02-04 13:47:10','2019-02-04 13:47:11',38,0,10,2);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (24,7,4,'111','121133',6,1,'11.000',1,'2019-02-04 13:53:05','2019-02-04 13:53:06',39,0,10,1);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (25,6,2,'121','123',6,1,'-122.000',1,'2019-02-11 23:26:41','2019-02-11 23:26:42',40,0,10,1);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (26,6,1,'fulano','1233',6,1,'1.220',1,'2019-02-13 15:21:54','2019-02-13 15:21:55',41,0,10,1);
insert  into `tbl_recepcion`(`ID`,`ID_cliente`,`ID_productor`,`chofer`,`guia`,`ID_especie`,`ID_descarga`,`temperatura`,`ID_destino`,`fecha`,`fecha_sistema`,`lote`,`estado`,`cantidad_pallets`,`ID_tipo`) values (27,6,1,'fulano','667',6,1,'11.000',1,'2019-02-13 16:45:04','2019-02-13 16:45:06',42,0,12,1);

/*Table structure for table `tbl_recepcion_detalle` */

DROP TABLE IF EXISTS `tbl_recepcion_detalle`;

CREATE TABLE `tbl_recepcion_detalle` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
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
  `posicion` bigint(20) NOT NULL,
  `usuario` varchar(15) NOT NULL,
  `sublote` bigint(20) DEFAULT '0',
  `uso_descuento` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=74 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_recepcion_detalle` */

insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (1,1,1,1,'Torito','2',1,'1','100.000','1.000','4.960','-3.960',1,'Madera','3','2019-01-03 16:37:38',0,'35',1,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (2,1,2,1,'Torito','2',2,'2','100.000','2.000','6.760','-4.760',1,'Madera','3','2019-01-03 16:41:33',0,'35',2,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (3,1,3,3,'Verde','2',3,'3','100.000','3.000','9.806','-6.806',2,'Metal','5','2019-01-03 16:46:52',0,'36',3,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (4,2,1,2,'Blanco/Amarillo','2',4,'4','100.000','4.000','12.300','-8.300',2,'Metal','5','2019-01-03 16:50:21',0,'37',1,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (5,2,2,1,'Torito','2',5,'5','100.000','5.000','12.160','-7.160',1,'Madera','3','2019-01-03 16:51:30',0,'38',2,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (6,2,3,5,'Rojo','2',6,'6','100.000','6.000','14.000','-8.000',2,'Metal','5','2019-01-03 16:52:07',0,'39',3,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (7,3,1,2,'Blanco/Amarillo','2',4,'FC4332','100.000','122.000','10.760','111.240',1,'Madera','3','2019-01-03 22:49:23',1,'54',1,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (8,3,2,2,'Blanco/Amarillo','2',50,'FC776','100.000','300.000','98.160','201.840',1,'Madera','3','2019-01-03 22:50:19',0,NULL,2,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (9,3,3,1,'Torito','2',10,'FC55433','100.000','700.000','21.160','678.840',1,'Madera','3','2019-01-03 22:52:36',0,'51',3,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (10,3,4,1,'Torito','2',55,'888','100.000','766.000','102.160','663.840',1,'Madera','3','2019-01-03 22:53:40',1,'53',4,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (11,3,5,1,'Torito','2',10,'fc5444','100.000','7888.000','21.160','7866.840',1,'Madera','3','2019-01-03 22:54:45',1,'53',5,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (12,3,6,2,'Blanco/Amarillo','2',1121,'122','100.000','1222.000','2133.060','-911.060',1,'Madera','3','2019-01-03 22:56:50',0,NULL,6,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (13,4,1,1,'Torito','2',50,'FC6547','100.000','6554.000','93.160','6460.840',1,'Madera','3','2019-01-03 23:24:20',0,NULL,1,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (14,5,1,1,'Torito','2',12,'FC001','100.000','100.000','24.760','75.240',1,'Madera','3','2019-01-04 00:12:40',0,'49',1,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (15,6,1,1,'Torito','2',50,'AZ001','100.000','100.000','93.160','6.840',1,'Madera','3','2019-01-04 12:04:41',0,'18',1,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (16,6,2,1,'Torito','2',10,'az002','100.000','200.000','21.160','178.840',1,'Madera','3','2019-01-04 12:05:03',0,NULL,2,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (17,6,3,1,'Torito','2',50,'az003','100.000','300.000','93.160','206.840',1,'Madera','3','2019-01-04 12:05:19',0,NULL,3,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (18,6,4,1,'Torito','2',12,'az004','100.000','111.000','24.760','86.240',1,'Madera','3','2019-01-04 12:06:04',0,NULL,4,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (19,6,5,1,'Torito','2',122,'az006','100.000','6554.000','222.760','6331.240',1,'Madera','3','2019-01-04 12:06:20',0,NULL,5,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (20,6,6,1,'Torito','2',10,'az007','100.000','700.000','21.160','678.840',1,'Madera','3','2019-01-04 12:06:33',0,NULL,6,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (21,6,7,1,'Torito','2',12,'az008','100.000','121.000','24.760','96.240',1,'Madera','3','2019-01-04 12:06:47',0,NULL,7,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (22,6,8,1,'Torito','2',10,'az009','100.000','121.000','21.160','99.840',1,'Madera','3','2019-01-04 12:06:59',0,'17',8,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (23,6,9,1,'Torito','2',20,'az010','100.000','1000.000','39.160','960.840',1,'Madera','3','2019-01-04 12:07:18',0,NULL,9,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (24,6,10,1,'Torito','2',12,'az011','100.000','1122.000','24.760','1097.240',1,'Madera','3','2019-01-04 12:07:40',0,NULL,10,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (25,7,1,1,'Torito','2',100,'fc001','1221.000','1221.000','183.160','1037.840',1,'Madera','3','2019-01-05 01:36:01',0,'49',1,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (26,9,1,1,'Torito','2',12,'fc099','211.000','211.000','24.760','186.240',1,'Madera','3','2019-01-07 17:41:05',0,NULL,1,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (27,12,1,1,'Torito','2',12,'FC02','123.100','123.100','24.760','1206.240',1,'Madera','3','2019-01-10 16:14:26',0,NULL,1,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (28,12,2,1,'Torito','2',12,'FC21','122.000','122.000','24.760','97.240',1,'Madera','3','2019-01-10 16:16:21',0,NULL,2,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (29,12,3,1,'Torito','2',12,'FC021','123.200','123.200','24.760','1207.240',1,'Madera','3','2019-01-10 16:26:54',0,NULL,3,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (30,11,1,1,'Torito','2',12,'1234','123.000','123.000','26.300','96.700',2,'Metal','5','2019-01-10 16:42:22',0,NULL,1,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (31,11,2,2,'Blanco/Amarillo','2',12,'112233','123.000','123.000','27.500','95.500',2,'Metal','5','2019-01-10 16:43:04',0,NULL,2,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (32,11,3,3,'Verde','2',2,'12','124.000','124.000','5.481','118.519',3,'Plastico','2','2019-01-10 16:43:35',0,NULL,3,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (33,13,1,5,'Rojo','2',12,'412','123.000','123.000','21.760','101.240',1,'Madera','3','2019-01-10 16:46:09',0,NULL,1,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (34,13,2,3,'Verde','2',21,'123412','231.000','231.000','40.442','190.558',2,'Metal','5','2019-01-10 16:46:45',0,NULL,2,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (35,13,3,4,'Azul','2',12,'1414','132.000','132.000','20.077','111.923',3,'Plastico','2','2019-01-10 16:47:13',0,NULL,3,'',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (36,14,1,1,'Torito','2',12,'1214','1231.100','1231.100','26.300','12284.700',2,'Metal','5','2019-01-17 15:59:46',0,'40',1,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (37,15,1,1,'Torito','2',12,'FC111','1234.000','1234.000','24.760','1209.240',1,'Madera','3','2019-01-23 11:05:05',0,NULL,1,'diegocade',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (38,15,2,2,'Blanco/Amarillo','2',4,'fc222','113.000','113.000','12.300','100.700',2,'Metal','5','2019-01-23 11:06:12',0,NULL,2,'diegocade',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (39,17,1,1,'Torito','2',5,'fc223','123.000','123.000','12.160','110.840',1,'Madera','3','2019-01-30 11:45:10',0,NULL,1,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (40,18,1,1,'Torito','2',12,'fc3243','123.000','123.000','24.760','98.240',1,'Madera','3','2019-01-30 13:23:53',0,NULL,1,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (41,18,2,2,'Blanco/Amarillo','2',9,'fc431','231.000','231.000','20.260','210.740',1,'Madera','3','2019-01-30 13:25:13',0,NULL,2,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (42,19,1,1,'Torito','2',12,'123','123.000','123.000','24.760','98.240',1,'Madera','3','2019-01-30 13:45:00',0,NULL,1,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (43,19,2,2,'Blanco/Amarillo','2',11,'890','123.000','123.000','24.060','98.940',1,'Madera','3','2019-01-30 13:46:18',0,NULL,2,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (44,19,3,2,'Blanco/Amarillo','2',7,'8901','111.000','111.000','15.377','95.623',3,'Plastico','2','2019-01-30 13:47:12',0,NULL,3,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (45,19,4,1,'Torito','2',4,'8902','123.000','123.000','10.360','112.640',1,'Madera','3','2019-01-30 13:49:44',0,NULL,4,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (46,20,1,1,'Torito','2',1,'12121212','123.000','123.000','4.960','118.040',1,'Madera','3','2019-01-30 13:52:39',0,NULL,1,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (47,20,2,1,'Torito','2',1,'1231444114','12.000','12.000','4.960','7.040',1,'Madera','3','2019-01-30 13:54:54',0,NULL,2,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (48,20,3,2,'Blanco/Amarillo','2',12,'a1234','123.000','123.000','27.500','95.500',2,'Metal','5','2019-01-30 13:55:05',0,NULL,3,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (49,19,5,3,'Verde','2',12,'12as','123.000','123.000','25.124','97.876',2,'Metal','5','2019-01-30 13:56:26',0,NULL,5,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (50,11,4,1,'Torito','2',12,'21122','123.000','123.000','24.760','98.240',1,'Madera','3','2019-01-30 16:04:37',0,NULL,4,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (51,11,5,2,'Blanco/Amarillo','2',13,'2332131','1222.000','1222.000','29.400','1192.600',2,'Metal','5','2019-01-30 16:04:48',0,NULL,5,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (52,5,2,1,'Torito','2',10,'FC097','199.000','199.000','21.160','177.840',1,'Madera','3','2019-02-04 00:33:08',0,'43',2,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (53,21,1,1,'Torito','2',10,'FC089','120.000','120.000','21.160','98.840',1,'Madera','3','2019-02-04 11:44:13',0,NULL,1,'usuario',2,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (54,22,1,1,'Torito','2',50,'FCG54','120.000','120.000','93.160','26.840',1,'Madera','3','2019-02-04 11:54:07',0,NULL,1,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (55,22,2,1,'Torito','2',12,'fc544','1222.000','1222.000','24.760','1197.240',1,'Madera','3','2019-02-04 11:56:16',0,NULL,2,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (56,22,3,1,'Torito','2',10,'FCG60','100.000','100.000','21.160','78.840',1,'Madera','3','2019-02-04 12:01:44',0,NULL,3,'usuario',3,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (57,22,4,1,'Torito','2',20,'FCG66','100.000','100.000','40.700','59.300',2,'Metal','5','2019-02-04 13:16:51',0,NULL,4,'usuario',4,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (58,22,5,1,'Torito','2',10,'HG122','123.000','123.000','21.160','101.840',1,'Madera','3','2019-02-04 13:37:07',0,NULL,5,'usuario',5,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (59,23,1,1,'Torito','2',10,'FT332','100.000','100.000','21.160','78.840',1,'Madera','3','2019-02-04 13:47:12',0,NULL,1,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (60,23,2,1,'Torito','2',30,'FA211','135.000','135.000','57.160','77.840',1,'Madera','3','2019-02-04 13:48:25',0,NULL,2,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (61,24,1,1,'Torito','2',12,'GF123','100.000','100.000','26.300','73.700',2,'Metal','5','2019-02-04 13:53:07',0,NULL,1,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (62,24,2,1,'Torito','2',122,'fc5544','234.000','234.000','222.760','11.240',1,'Madera','3','2019-02-04 13:55:06',0,NULL,2,'usuario',6,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (63,24,3,2,'Blanco/Amarillo','2',11,'HGF44','121.000','121.000','24.060','96.940',1,'Madera','3','2019-02-04 13:59:05',0,NULL,3,'usuario',7,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (64,23,3,1,'Torito','2',12,'11111','121.000','121.000','24.760','96.240',1,'Madera','3','2019-02-04 14:01:28',0,NULL,3,'usuario',8,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (65,3,7,1,'Torito','2',20,'FCT988','500.000','500.000','39.160','460.840',1,'Madera','3','2019-02-11 13:47:20',0,NULL,7,'usuario',9,1);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (66,25,1,1,'Torito','2',122,'FC10002','11221.000','11221.000','222.760','10998.240',1,'Madera','3','2019-02-11 23:26:43',0,NULL,1,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (67,25,2,1,'Torito','2',221,'FC922','1122.000','1122.000','402.500','719.500',2,'Metal','5','2019-02-11 23:27:00',0,NULL,2,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (68,25,3,2,'Blanco/Amarillo','2',433,'GF444','3255.000','3255.000','825.860','2429.140',1,'Madera','3','2019-02-11 23:27:52',0,NULL,3,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (69,5,3,1,'Torito','2',33,'333','334.000','334.000','62.560','271.440',1,'Madera','3','2019-02-11 23:29:26',0,NULL,3,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (70,26,1,1,'Torito','2',10,'FC012','100.000','100.000','21.160','78.840',1,'Madera','3','2019-02-13 15:22:39',0,NULL,1,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (71,5,4,1,'Torito','2',30,'PFS656','567.000','567.000','58.700','508.300',2,'Metal','5','2019-02-13 16:39:05',0,NULL,4,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (72,27,1,2,'Blanco/Amarillo','2',122,'PF112','1233.000','1233.000','236.500','996.500',2,'Metal','5','2019-02-13 16:45:07',0,NULL,1,'usuario',0,0);
insert  into `tbl_recepcion_detalle`(`ID`,`ID_Recepcion`,`item`,`ID_Bandeja`,`bandeja`,`peso_bandeja`,`cantidad_bandejas`,`folio`,`kilos_brutos_original`,`kilos_brutos`,`tara`,`kilos_netos`,`ID_pallet`,`tipo_pallet`,`peso_pallet`,`fecha`,`estado`,`Maquila`,`posicion`,`usuario`,`sublote`,`uso_descuento`) values (73,27,2,1,'Torito','2',60,'PF998','2002.000','2002.000','111.160','1890.840',1,'Madera','3','2019-02-13 16:57:55',0,NULL,2,'usuario',0,0);

/*Table structure for table `tbl_tipo_usuario` */

DROP TABLE IF EXISTS `tbl_tipo_usuario`;

CREATE TABLE `tbl_tipo_usuario` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_tipo_usuario` */

insert  into `tbl_tipo_usuario`(`id`,`descripcion`) values (1,'Administrador');
insert  into `tbl_tipo_usuario`(`id`,`descripcion`) values (2,'Limitado');

/*Table structure for table `tbl_tipo_usuario_permisos` */

DROP TABLE IF EXISTS `tbl_tipo_usuario_permisos`;

CREATE TABLE `tbl_tipo_usuario_permisos` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `id_tipo_usuario` bigint(20) NOT NULL,
  `permisos` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_tipo_usuario_permisos` */

insert  into `tbl_tipo_usuario_permisos`(`id`,`id_tipo_usuario`,`permisos`) values (1,1,'1,2,3,4');
insert  into `tbl_tipo_usuario_permisos`(`id`,`id_tipo_usuario`,`permisos`) values (2,2,'1');

/*Table structure for table `tbl_tipoarmado` */

DROP TABLE IF EXISTS `tbl_tipoarmado`;

CREATE TABLE `tbl_tipoarmado` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50) DEFAULT NULL,
  UNIQUE KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_tipoarmado` */

insert  into `tbl_tipoarmado`(`ID`,`descripcion`) values (1,'Maritimo-');
insert  into `tbl_tipoarmado`(`ID`,`descripcion`) values (2,'Guarda+');
insert  into `tbl_tipoarmado`(`ID`,`descripcion`) values (3,'Aereo*');

/*Table structure for table `tbl_tipocomercial` */

DROP TABLE IF EXISTS `tbl_tipocomercial`;

CREATE TABLE `tbl_tipocomercial` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_tipocomercial` */

insert  into `tbl_tipocomercial`(`ID`,`descripcion`) values (1,'Comercial');
insert  into `tbl_tipocomercial`(`ID`,`descripcion`) values (2,'Merma');

/*Table structure for table `tbl_tipodescarga` */

DROP TABLE IF EXISTS `tbl_tipodescarga`;

CREATE TABLE `tbl_tipodescarga` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_tipodescarga` */

insert  into `tbl_tipodescarga`(`ID`,`Descripcion`) values (1,'Paletizado');
insert  into `tbl_tipodescarga`(`ID`,`Descripcion`) values (2,'Piso');

/*Table structure for table `tbl_tipomercado` */

DROP TABLE IF EXISTS `tbl_tipomercado`;

CREATE TABLE `tbl_tipomercado` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_tipomercado` */

insert  into `tbl_tipomercado`(`ID`,`descripcion`) values (1,'EEUU');
insert  into `tbl_tipomercado`(`ID`,`descripcion`) values (2,'CHINA');
insert  into `tbl_tipomercado`(`ID`,`descripcion`) values (3,'EUROPA');

/*Table structure for table `tbl_tiporecepcion` */

DROP TABLE IF EXISTS `tbl_tiporecepcion`;

CREATE TABLE `tbl_tiporecepcion` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_tiporecepcion` */

insert  into `tbl_tiporecepcion`(`ID`,`Descripcion`) values (1,'Convencional');
insert  into `tbl_tiporecepcion`(`ID`,`Descripcion`) values (2,'Organico');

/*Table structure for table `tbl_usuario` */

DROP TABLE IF EXISTS `tbl_usuario`;

CREATE TABLE `tbl_usuario` (
  `usuario` varchar(15) NOT NULL,
  `contrasenia` varchar(20) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `apellido` varchar(30) NOT NULL,
  `id_tipo_usuario` bigint(20) NOT NULL,
  PRIMARY KEY (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `tbl_usuario` */

insert  into `tbl_usuario`(`usuario`,`contrasenia`,`nombre`,`apellido`,`id_tipo_usuario`) values ('diegocade','1234','Diego','Cadena',1);
insert  into `tbl_usuario`(`usuario`,`contrasenia`,`nombre`,`apellido`,`id_tipo_usuario`) values ('lsalas','123','Luis','Salas',2);
insert  into `tbl_usuario`(`usuario`,`contrasenia`,`nombre`,`apellido`,`id_tipo_usuario`) values ('usuario','1234','Fulano','Henriquez',1);

/*Table structure for table `tbl_variedad` */

DROP TABLE IF EXISTS `tbl_variedad`;

CREATE TABLE `tbl_variedad` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(50) DEFAULT NULL,
  `ID_especie` bigint(20) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_variedad` */

insert  into `tbl_variedad`(`ID`,`Descripcion`,`ID_especie`) values (1,'Emeral *1',0);
insert  into `tbl_variedad`(`ID`,`Descripcion`,`ID_especie`) values (2,'Emeral *2',0);
insert  into `tbl_variedad`(`ID`,`Descripcion`,`ID_especie`) values (3,'Emeral *3',0);
insert  into `tbl_variedad`(`ID`,`Descripcion`,`ID_especie`) values (5,'Emeral *4',0);

/*Table structure for table `v_comercial_maquila` */

DROP TABLE IF EXISTS `v_comercial_maquila`;

/*!50001 DROP VIEW IF EXISTS `v_comercial_maquila` */;
/*!50001 DROP TABLE IF EXISTS `v_comercial_maquila` */;

/*!50001 CREATE TABLE `v_comercial_maquila` (
  `ID_Cliente` bigint(20) DEFAULT NULL,
  `ID_Productor` bigint(20) DEFAULT NULL,
  `ID_Tipo` bigint(20) DEFAULT NULL,
  `Tipo` varchar(50) DEFAULT NULL,
  `folio` varchar(50) DEFAULT NULL,
  `kilos_netos` decimal(10,3) DEFAULT NULL,
  `estado` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 */;

/*Table structure for table `v_exportacion_maquila` */

DROP TABLE IF EXISTS `v_exportacion_maquila`;

/*!50001 DROP VIEW IF EXISTS `v_exportacion_maquila` */;
/*!50001 DROP TABLE IF EXISTS `v_exportacion_maquila` */;

/*!50001 CREATE TABLE `v_exportacion_maquila` (
  `ID_cliente` bigint(20) DEFAULT NULL,
  `ID_productor` bigint(20) DEFAULT NULL,
  `Folio` varchar(50) DEFAULT NULL,
  `ID_Embalaje` bigint(20) DEFAULT NULL,
  `Embalaje` varchar(50) DEFAULT NULL,
  `peso_teorico` decimal(10,3) DEFAULT NULL,
  `cantidad_cajas` bigint(20) DEFAULT NULL,
  `Total_Peso` decimal(29,3) DEFAULT NULL,
  `cantidad_potes` bigint(30) DEFAULT NULL,
  `estado` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 */;

/*Table structure for table `v_recepcion_lista` */

DROP TABLE IF EXISTS `v_recepcion_lista`;

/*!50001 DROP VIEW IF EXISTS `v_recepcion_lista` */;
/*!50001 DROP TABLE IF EXISTS `v_recepcion_lista` */;

/*!50001 CREATE TABLE `v_recepcion_lista` (
  `ID_Recepcion` bigint(20) DEFAULT NULL,
  `ID_Cliente` bigint(20) DEFAULT NULL,
  `Cliente` varchar(50),
  `ID_Productor` bigint(20) DEFAULT NULL,
  `Productor` varchar(50),
  `chofer` varchar(50) DEFAULT NULL,
  `guia` varchar(50) DEFAULT NULL,
  `ID_Especie` bigint(20) DEFAULT NULL,
  `especie` varchar(50),
  `ID_Descarga` bigint(20) DEFAULT NULL,
  `Descarga` varchar(50),
  `temperatura` decimal(10,3) DEFAULT NULL,
  `ID_Destino` bigint(20) DEFAULT NULL,
  `Destino` varchar(50),
  `fecha` datetime DEFAULT NULL,
  `lote` bigint(20) DEFAULT NULL,
  `usuario` varchar(15) NOT NULL,
  `Total_Pallet` bigint(20),
  `item` bigint(20) DEFAULT NULL,
  `ID_Bandeja` bigint(20) DEFAULT NULL,
  `bandeja` varchar(50) DEFAULT NULL,
  `peso_bandeja` decimal(5,0) DEFAULT NULL,
  `folio` varchar(50) DEFAULT NULL,
  `Kilos_brutos` decimal(10,3) DEFAULT NULL,
  `tara` decimal(10,3) DEFAULT NULL,
  `Kilos_netos` decimal(10,3) DEFAULT NULL,
  `ID_Pallet` bigint(20) DEFAULT NULL,
  `tipo_pallet` varchar(50) DEFAULT NULL,
  `peso_pallet` decimal(5,0) DEFAULT NULL,
  `sublote` bigint(20) DEFAULT NULL,
  `uso_descuento` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 */;

/*Table structure for table `v_recepcion_lista_old` */

DROP TABLE IF EXISTS `v_recepcion_lista_old`;

/*!50001 DROP VIEW IF EXISTS `v_recepcion_lista_old` */;
/*!50001 DROP TABLE IF EXISTS `v_recepcion_lista_old` */;

/*!50001 CREATE TABLE `v_recepcion_lista_old` (
  `ID_Recepcion` bigint(20) DEFAULT NULL,
  `ID_Cliente` bigint(20) DEFAULT NULL,
  `Cliente` varchar(50),
  `ID_Productor` bigint(20) DEFAULT NULL,
  `Productor` varchar(50),
  `chofer` varchar(50) DEFAULT NULL,
  `guia` varchar(50) DEFAULT NULL,
  `ID_Especie` bigint(20) DEFAULT NULL,
  `especie` varchar(50),
  `ID_Descarga` bigint(20) DEFAULT NULL,
  `Descarga` varchar(50),
  `temperatura` decimal(10,3) DEFAULT NULL,
  `ID_Destino` bigint(20) DEFAULT NULL,
  `Destino` varchar(50),
  `fecha` datetime DEFAULT NULL,
  `lote` bigint(20) DEFAULT NULL,
  `usuario` varchar(15) NOT NULL,
  `Total_Pallet` bigint(20),
  `item` bigint(20) DEFAULT NULL,
  `ID_Bandeja` bigint(20) DEFAULT NULL,
  `bandeja` varchar(50) DEFAULT NULL,
  `peso_bandeja` decimal(5,0) DEFAULT NULL,
  `folio` varchar(50) DEFAULT NULL,
  `Kilos_brutos` decimal(10,3) DEFAULT NULL,
  `tara` decimal(10,3) DEFAULT NULL,
  `Kilos_netos` decimal(10,3) DEFAULT NULL,
  `ID_Pallet` bigint(20) DEFAULT NULL,
  `tipo_pallet` varchar(50) DEFAULT NULL,
  `peso_pallet` decimal(5,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 */;

/*Table structure for table `v_recepcion_maquila` */

DROP TABLE IF EXISTS `v_recepcion_maquila`;

/*!50001 DROP VIEW IF EXISTS `v_recepcion_maquila` */;
/*!50001 DROP TABLE IF EXISTS `v_recepcion_maquila` */;

/*!50001 CREATE TABLE `v_recepcion_maquila` (
  `ID_Cliente` bigint(20) DEFAULT NULL,
  `ID_Productor` bigint(20) DEFAULT NULL,
  `folio` varchar(50) DEFAULT NULL,
  `bandeja` varchar(50) DEFAULT NULL,
  `kilos_netos` decimal(10,3) DEFAULT NULL,
  `cantidad_bandejas` bigint(20) DEFAULT NULL,
  `estado` int(11) NOT NULL DEFAULT '0',
  `guia` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 */;

/*Table structure for table `v_sublote_lista` */

DROP TABLE IF EXISTS `v_sublote_lista`;

/*!50001 DROP VIEW IF EXISTS `v_sublote_lista` */;
/*!50001 DROP TABLE IF EXISTS `v_sublote_lista` */;

/*!50001 CREATE TABLE `v_sublote_lista` (
  `ID_Recepcion` bigint(20) NOT NULL DEFAULT '0',
  `ID_Cliente` bigint(20) DEFAULT NULL,
  `cliente` varchar(50),
  `ID_Productor` bigint(20) DEFAULT NULL,
  `productor` varchar(50),
  `chofer` varchar(50) DEFAULT NULL,
  `guia` varchar(50) DEFAULT NULL,
  `ID_Especie` bigint(20) DEFAULT NULL,
  `especie` varchar(50),
  `ID_Descarga` bigint(20) DEFAULT NULL,
  `descarga` varchar(50),
  `temperatura` decimal(10,3) DEFAULT NULL,
  `ID_Destino` bigint(20) DEFAULT NULL,
  `destino` varchar(50),
  `fecha` datetime DEFAULT NULL,
  `lote` bigint(20) DEFAULT NULL,
  `id_tipo` bigint(20) NOT NULL,
  `tipo` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 */;

/*Table structure for table `v_sublote_lista_old` */

DROP TABLE IF EXISTS `v_sublote_lista_old`;

/*!50001 DROP VIEW IF EXISTS `v_sublote_lista_old` */;
/*!50001 DROP TABLE IF EXISTS `v_sublote_lista_old` */;

/*!50001 CREATE TABLE `v_sublote_lista_old` (
  `ID_Recepcion` bigint(20) NOT NULL DEFAULT '0',
  `ID_Cliente` bigint(20) DEFAULT NULL,
  `cliente` varchar(50),
  `ID_Productor` bigint(20) DEFAULT NULL,
  `productor` varchar(50),
  `chofer` varchar(50) DEFAULT NULL,
  `guia` varchar(50) DEFAULT NULL,
  `ID_Especie` bigint(20) DEFAULT NULL,
  `especie` varchar(50),
  `ID_Descarga` bigint(20) DEFAULT NULL,
  `descarga` varchar(50),
  `temperatura` decimal(10,3) DEFAULT NULL,
  `ID_Destino` bigint(20) DEFAULT NULL,
  `destino` varchar(50),
  `fecha` datetime DEFAULT NULL,
  `lote` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 */;

/*View structure for view v_comercial_maquila */

/*!50001 DROP TABLE IF EXISTS `v_comercial_maquila` */;
/*!50001 DROP VIEW IF EXISTS `v_comercial_maquila` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`atc`@`%` SQL SECURITY DEFINER VIEW `v_comercial_maquila` AS select `t1`.`ID_Cliente` AS `ID_Cliente`,`t1`.`ID_Productor` AS `ID_Productor`,`t1`.`ID_Tipo` AS `ID_Tipo`,`t2`.`descripcion` AS `Tipo`,`t1`.`folio` AS `folio`,`t1`.`kilos_netos` AS `kilos_netos`,`t1`.`estado` AS `estado` from (`tbl_comercial` `t1` left join `tbl_tipocomercial` `t2` on((`t2`.`ID` = `t1`.`ID_Tipo`))) */;

/*View structure for view v_exportacion_maquila */

/*!50001 DROP TABLE IF EXISTS `v_exportacion_maquila` */;
/*!50001 DROP VIEW IF EXISTS `v_exportacion_maquila` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`atc`@`%` SQL SECURITY DEFINER VIEW `v_exportacion_maquila` AS select `t1`.`ID_Cliente` AS `ID_cliente`,`t1`.`ID_Productor` AS `ID_productor`,`t1`.`Folio` AS `Folio`,`t1`.`ID_Embalaje` AS `ID_Embalaje`,`t2`.`descripcion` AS `Embalaje`,`t2`.`peso` AS `peso_teorico`,`t1`.`cantidad_cajas` AS `cantidad_cajas`,(`t1`.`cantidad_cajas` * `t2`.`peso`) AS `Total_Peso`,(`t1`.`cantidad_cajas` * `t2`.`potes`) AS `cantidad_potes`,`t1`.`estado` AS `estado` from (`tbl_exportacion` `t1` left join `tbl_embalaje` `t2` on((`t2`.`ID` = `t1`.`ID_Embalaje`))) */;

/*View structure for view v_recepcion_lista */

/*!50001 DROP TABLE IF EXISTS `v_recepcion_lista` */;
/*!50001 DROP VIEW IF EXISTS `v_recepcion_lista` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`atc`@`%` SQL SECURITY DEFINER VIEW `v_recepcion_lista` AS (select `t1`.`ID_Recepcion` AS `ID_Recepcion`,`t2`.`ID_cliente` AS `ID_Cliente`,`t3`.`Cliente` AS `Cliente`,`t2`.`ID_productor` AS `ID_Productor`,`t4`.`descripcion` AS `Productor`,`t2`.`chofer` AS `chofer`,`t2`.`guia` AS `guia`,`t2`.`ID_especie` AS `ID_Especie`,`t5`.`Descripcion` AS `especie`,`t2`.`ID_descarga` AS `ID_Descarga`,`t6`.`Descripcion` AS `Descarga`,`t2`.`temperatura` AS `temperatura`,`t2`.`ID_destino` AS `ID_Destino`,`t7`.`Descripcion` AS `Destino`,`t2`.`fecha` AS `fecha`,`t2`.`lote` AS `lote`,`t1`.`usuario` AS `usuario`,`t2`.`cantidad_pallets` AS `Total_Pallet`,`t1`.`item` AS `item`,`t1`.`ID_Bandeja` AS `ID_Bandeja`,`t1`.`bandeja` AS `bandeja`,`t1`.`peso_bandeja` AS `peso_bandeja`,`t1`.`folio` AS `folio`,`t1`.`kilos_brutos` AS `Kilos_brutos`,`t1`.`tara` AS `tara`,`t1`.`kilos_netos` AS `Kilos_netos`,`t1`.`ID_pallet` AS `ID_Pallet`,`t1`.`tipo_pallet` AS `tipo_pallet`,`t1`.`peso_pallet` AS `peso_pallet`,`t1`.`sublote` AS `sublote`,`t1`.`uso_descuento` AS `uso_descuento` from ((((((`tbl_recepcion_detalle` `t1` left join `tbl_recepcion` `t2` on((`t2`.`ID` = `t1`.`ID_Recepcion`))) left join `tbl_cliente` `t3` on((`t3`.`ID` = `t2`.`ID_cliente`))) left join `tbl_productor` `t4` on((`t4`.`codigo` = `t2`.`ID_productor`))) left join `tbl_especie` `t5` on((`t5`.`ID_especie` = `t2`.`ID_especie`))) left join `tbl_tipodescarga` `t6` on((`t6`.`ID` = `t2`.`ID_descarga`))) left join `tbl_destinorecepcion` `t7` on((`t7`.`ID` = `t2`.`ID_destino`)))) */;

/*View structure for view v_recepcion_lista_old */

/*!50001 DROP TABLE IF EXISTS `v_recepcion_lista_old` */;
/*!50001 DROP VIEW IF EXISTS `v_recepcion_lista_old` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`atc`@`%` SQL SECURITY DEFINER VIEW `v_recepcion_lista_old` AS select `t1`.`ID_Recepcion` AS `ID_Recepcion`,`t2`.`ID_cliente` AS `ID_Cliente`,`t3`.`Cliente` AS `Cliente`,`t2`.`ID_productor` AS `ID_Productor`,`t4`.`descripcion` AS `Productor`,`t2`.`chofer` AS `chofer`,`t2`.`guia` AS `guia`,`t2`.`ID_especie` AS `ID_Especie`,`t5`.`Descripcion` AS `especie`,`t2`.`ID_descarga` AS `ID_Descarga`,`t6`.`Descripcion` AS `Descarga`,`t2`.`temperatura` AS `temperatura`,`t2`.`ID_destino` AS `ID_Destino`,`t7`.`Descripcion` AS `Destino`,`t2`.`fecha` AS `fecha`,`t2`.`lote` AS `lote`,`t1`.`usuario` AS `usuario`,`t2`.`cantidad_pallets` AS `Total_Pallet`,`t1`.`item` AS `item`,`t1`.`ID_Bandeja` AS `ID_Bandeja`,`t1`.`bandeja` AS `bandeja`,`t1`.`peso_bandeja` AS `peso_bandeja`,`t1`.`folio` AS `folio`,`t1`.`kilos_brutos` AS `Kilos_brutos`,`t1`.`tara` AS `tara`,`t1`.`kilos_netos` AS `Kilos_netos`,`t1`.`ID_pallet` AS `ID_Pallet`,`t1`.`tipo_pallet` AS `tipo_pallet`,`t1`.`peso_pallet` AS `peso_pallet` from ((((((`tbl_recepcion_detalle` `t1` left join `tbl_recepcion` `t2` on((`t2`.`ID` = `t1`.`ID_Recepcion`))) left join `tbl_cliente` `t3` on((`t3`.`ID` = `t2`.`ID_cliente`))) left join `tbl_productor` `t4` on((`t4`.`codigo` = `t2`.`ID_productor`))) left join `tbl_especie` `t5` on((`t5`.`ID_especie` = `t2`.`ID_especie`))) left join `tbl_tipodescarga` `t6` on((`t6`.`ID` = `t2`.`ID_descarga`))) left join `tbl_destinorecepcion` `t7` on((`t7`.`ID` = `t2`.`ID_destino`))) */;

/*View structure for view v_recepcion_maquila */

/*!50001 DROP TABLE IF EXISTS `v_recepcion_maquila` */;
/*!50001 DROP VIEW IF EXISTS `v_recepcion_maquila` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`atc`@`%` SQL SECURITY DEFINER VIEW `v_recepcion_maquila` AS (select `t2`.`ID_cliente` AS `ID_Cliente`,`t2`.`ID_productor` AS `ID_Productor`,`t1`.`folio` AS `folio`,`t1`.`bandeja` AS `bandeja`,`t1`.`kilos_netos` AS `kilos_netos`,`t1`.`cantidad_bandejas` AS `cantidad_bandejas`,`t1`.`estado` AS `estado`,`t2`.`guia` AS `guia` from (`tbl_recepcion_detalle` `t1` left join `tbl_recepcion` `t2` on((`t2`.`ID` = `t1`.`ID_Recepcion`)))) */;

/*View structure for view v_sublote_lista */

/*!50001 DROP TABLE IF EXISTS `v_sublote_lista` */;
/*!50001 DROP VIEW IF EXISTS `v_sublote_lista` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`atc`@`%` SQL SECURITY DEFINER VIEW `v_sublote_lista` AS (select `t1`.`ID` AS `ID_Recepcion`,`t1`.`ID_cliente` AS `ID_Cliente`,`t3`.`Cliente` AS `cliente`,`t1`.`ID_productor` AS `ID_Productor`,`t4`.`descripcion` AS `productor`,`t1`.`chofer` AS `chofer`,`t1`.`guia` AS `guia`,`t1`.`ID_especie` AS `ID_Especie`,`t5`.`Descripcion` AS `especie`,`t1`.`ID_descarga` AS `ID_Descarga`,`t6`.`Descripcion` AS `descarga`,`t1`.`temperatura` AS `temperatura`,`t1`.`ID_destino` AS `ID_Destino`,`t7`.`Descripcion` AS `destino`,`t1`.`fecha` AS `fecha`,`t1`.`lote` AS `lote`,`t1`.`ID_tipo` AS `id_tipo`,`t8`.`Descripcion` AS `tipo` from ((((((`tbl_recepcion` `t1` left join `tbl_cliente` `t3` on((`t3`.`ID` = `t1`.`ID_cliente`))) left join `tbl_productor` `t4` on((`t4`.`codigo` = `t1`.`ID_productor`))) left join `tbl_especie` `t5` on((`t5`.`ID_especie` = `t1`.`ID_especie`))) left join `tbl_tipodescarga` `t6` on((`t6`.`ID` = `t1`.`ID_descarga`))) left join `tbl_destinorecepcion` `t7` on((`t7`.`ID` = `t1`.`ID_destino`))) left join `tbl_tiporecepcion` `t8` on((`t8`.`ID` = `t1`.`ID_tipo`)))) */;

/*View structure for view v_sublote_lista_old */

/*!50001 DROP TABLE IF EXISTS `v_sublote_lista_old` */;
/*!50001 DROP VIEW IF EXISTS `v_sublote_lista_old` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`atc`@`%` SQL SECURITY DEFINER VIEW `v_sublote_lista_old` AS (select `t1`.`ID` AS `ID_Recepcion`,`t1`.`ID_cliente` AS `ID_Cliente`,`t3`.`Cliente` AS `cliente`,`t1`.`ID_productor` AS `ID_Productor`,`t4`.`descripcion` AS `productor`,`t1`.`chofer` AS `chofer`,`t1`.`guia` AS `guia`,`t1`.`ID_especie` AS `ID_Especie`,`t5`.`Descripcion` AS `especie`,`t1`.`ID_descarga` AS `ID_Descarga`,`t6`.`Descripcion` AS `descarga`,`t1`.`temperatura` AS `temperatura`,`t1`.`ID_destino` AS `ID_Destino`,`t7`.`Descripcion` AS `destino`,`t1`.`fecha` AS `fecha`,`t1`.`lote` AS `lote` from (((((`tbl_recepcion` `t1` left join `tbl_cliente` `t3` on((`t3`.`ID` = `t1`.`ID_cliente`))) left join `tbl_productor` `t4` on((`t4`.`codigo` = `t1`.`ID_productor`))) left join `tbl_especie` `t5` on((`t5`.`ID_especie` = `t1`.`ID_especie`))) left join `tbl_tipodescarga` `t6` on((`t6`.`ID` = `t1`.`ID_descarga`))) left join `tbl_destinorecepcion` `t7` on((`t7`.`ID` = `t1`.`ID_destino`)))) */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
