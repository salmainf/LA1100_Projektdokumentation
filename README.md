# Projektdokumentation
# Projektdokumentation

Tanner

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|23.08.22| 0.01  | Start mit der Projektdokumentation, Userstories, Diagramm, Testfälle und Arbeitspaketen|
|30.08.22| 0.02  | Start mit realisieren, programmieren des Numberguessers|    
|06.09.22| 0.03  | Fortsetzen vom realisieren, Ende des realisieren|
|13.09.22| 0.04  | Erstellen des Lernberichts, Abgabe des Projekts|

## 1 Informieren

### 1.1 Ihr Projekt

Wir programmieren ein kleines Spiel, einen Numberguesser, dort versucht man, als Spieler eine zufällig generierte Zahl,zwischen 1 und 100, zu erraten. 

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |  Funktional     | Muss | Als ein Spieler möchte ich zufällige Zahlen eingeben können, damit ich die Zahl richtig errate |
| 2    |  Funktional     | Muss | Als ein Programmierer möchte ich zufällige Zahlen ausgeben können und Rückmeldungen geben, damit der Spieler diese Zahl erraten kann |
| 3    |  Qualität       | Muss | Als ein Spieler möchte ich eine Mitteilung erhalten, ob ich die Zahl zu hoch oder zu  niedrig eingegeben habe|
| 4    |  Funktional     | Muss | Als ein Programmierer möchte ich bei einer ungültigen Eingabe eine Rückmeldung geben können|
| 5    |  Qualität       | Muss | Als ein Spieler möchte ich, dass ich nach dem erraten der Zahl meine Versuche angezeigt bekomme|


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |Spiel startet, zufällige Zahl generiert, warten auf Eingabe Benutzer|  Eingeben von Zahl|Ausgabe von meiner eingegebener Zahl|
| 1.2  |Spiel läuft, Benutzer hat Zahl eingegeben| Zahl kontrollieren/Rückmeldung geben| Ausgabe, ob Zahl richtig ist, Rückmeldung ausgeben|
| 1.3  |Spiel ausgeführt, Zahl eingegeben| Warten nach eingabe von Zahl auf Rückmeldung | Erhalten von Rückmeldung, ob Zahl richtig ist|
| 1.4  |Spiel läuft, warten auf Eingabe Benutzer| Eingabe überprüfen, Eingabe ungültig|Ausgabe einer Nachricht und erneuter Versuch statt Ende des Programms|
| 1.5  |Spiel läuft, schon mehrmals falsch geraten| Benutzer gibt richtige Zahl ein|Ausgabe der gebrauchten Versuche|


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
| 5.A  |  06.9.22     |Salma Tanner| Nach erraten der Zahl, werden gebrauchte Versuche ausgegeben| 45 Min|
Total: 6h




## 3 Entscheiden



## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |30.8.22|Salma Tanner|45min|15min|
| 2.A  |30.8.22|Salma Tanner|45min|15min|
| 2.B  |30.8.22|Salma Tanner|45min|30min|
| 3.A  |30.8.22|Salma Tanner|45min|30min|
| 4.A  |06.9.22|Salma Tanner|45min|45min|


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |13.9.22|Alles funktioniert, korrekte Ausgabe|Salma Tanner|
| 1.2  |13.9.22|Vollständige ausgabe|Salma Tanner|
| 1.3  |13.9.22|Funktioniert alles|Salma Tanner|
| 1.4  |13.9.22|Guter Umgang mit Fehleingabe, korrekt|Salma Tanner|
| 1.5  |13.9.22|Anzeigen der Versuche funktioniert|Salma Tanner|

Das Spiel funktioniert und beinhaltet alle Vorgaben. Jedoch hat es einen Fehler bei der Eingabe. Wenn man eine höhere Zahl als hundert eingibt, wird diese auch akzeptiert, nur bei etwas anderem als einer Zahl gibt es eine Fehlermeldung aus.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |Benutzer-Eingabe einer Zahl über oder unter 1-100|Fehlermeldung, Aufforderung zur erneuter Eingabe|Rückmeldung, dass die Zahl zu klein oder zu gross ist|                      


## 6 Auswerten

https://github.com/salmainf/Lernbericht_Numberguesser/blob/main/README.md
