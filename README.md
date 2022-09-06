# Projektdokumentation
# Projektdokumentation

Tanner

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|23.08.22| 0.01  | Start mit der Projektdokumentation, Userstories, Diagramm, Testfälle und Arbeitspaketen|
|30.08.22| 0.02  | Start mit realisieren, programmieren des Numberguessers|    
|06.09.22| 0.03  | Fortsetzen vom realisieren, Ende des realisieren|

## 1 Informieren

### 1.1 Ihr Projekt

Wir programmieren ein kleines Spiel, einen Numberguesser, dort versucht man, als Spieler eine zufällig generierte Zahl zu erraten. 

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |  Funktional     | Muss | Als ein Spieler möchte ich zufällige Zahlen eingeben können, damit ich die Zahl richtig errate |
| 2    |  Funktional     | Muss | Als ein Programmierer möchte ich zufällige Zahlen ausgeben können und Rückmeldungen geben, damit der Spieler diese Zahl erraten kann |
| 3    |  Qualität       | Muss | Als ein Spieler möchte ich eine Mitteilung erhalten, ob ich die Zahl zu hoch oder zu  niedrig eingegeben habe|
| 4    |  Funktional     | Muss | Als ein Programmierer möchte ich bei einer ungültigen Eingabe eine Rückmeldung geben können|
| 5    |  Funktional     | Muss | Als ein Spieler möchte ich nach dem erraten der Zufallszahl sehen, wieviele Versuche ich gebraucht habe|

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |Spiel startet, zufällige Zahl generiert, warten auf Eingabe Benutzer|  Eingeben von Zahl|Ausgabe von meiner eingegebener Zahl|
| 1.2  |Spiel läuft, Benutzer hat Zahl eingegeben| Zahl kontrollieren/Rückmeldung geben| Ausgabe, ob Zahl richtig ist, Rückmeldung ausgeben|
| 1.3  |Spiel ausgeführt, Zahl eingegeben| Warten nach eingabe von Zahl auf Rückmeldung | Erhalten von Rückmeldung, ob Zahl richtig ist|
| 1.4  |Spiel läuft, warten auf Eingabe Benutzer| Eingabe überprüfen, Eingabe ungültig|Ausgabe einer Nachricht und erneuter Versuch statt Ende des Programms|
| 1.5  |Spiel läuft, Zahl erraten| Errechnen der totalen Versuche| Ausgabe der totalen Versuche|

### 1.4 Diagramme

![grafik](https://user-images.githubusercontent.com/110892351/186116210-84b1487f-cdf9-493f-9333-d1eac3e26092.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  13.9.22     |Salma Tanner| Erstellen von Benutzereingaben für Zahl|45 Min|
| 2.A  |  13.9.22     |Salma Tanner| Erstellen von zufälligem Zahlengenerator|45 Min|
| 2.B  |  13.9.22     |Salma Tanner| Erstellen von Kontrolle für Benutzerzahl/Rückmeldung |45 Min|
| 3.A  |  13.9.22     |Salma Tanner| Ausgabe von Rückmeldung an Benutzer|45 Min|
| 4.A  |  06.9.22     |Salma Tanner| Bei ungültiger Eingabe, erneuter versuch anstelle von Programmm-Ende| 45 Min|
| 5.A  |  06.9.22     |Salma Tanner| Nach erraten der Zahl, Ausgabe von totalen Versuchen|45 Min|
Total: 6h




## 3 Entscheiden



## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |30.8.22|Salma Tanner|45min|15min|
| 2.A  |30.8.22|Salma Tanner|45min|15min|
| 2.B  |30.8.22|Salma Tanner|45min|30min|
| 3.A  |30.8.22|Salma Tanner|45min|30min|


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
