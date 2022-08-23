# Projektdokumentation
# Projekt-Dokumentation

Tanner

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|23.08.22| 0.0.1  | Start mit der Projektdokumentation, Userstories, Diagramm,Testfälle und Arbeitspaketen|
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Wir programmieren ein kleines Spiel, einen Numberguesser, dort versucht man als Spieler eine zufällig generierte Zahl zu erraten. 

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |  Funktional     | Muss | Als ein Spieler möchte ich zufällige Zahlen eingeben können, damit ich die Zahl richtig errate |
| 2    |  Funktional     | Muss | Als ein Programmierer möchte ich zufällige Zahlen ausgeben können und Rückmeldungen geben, damit der Spieler diese Zahl erraten kann |
| 3    |  Qualität       | Muss | Als ein Spieler möchte ich eine Mitteilung erhalten, ob ich die Zahl zu hoch oder zu  niedrig eingegeben habe|


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |Spiel startet, zufällige Zahl generiert, warten auf Eingabe Benutzer|  Eingeben von Zahl|Ausgabe von meiner eingegebener Zahl|
| 1.2  |Spiel läuft, Benutzer hat Zahl eingegeben| Zahl kontrollieren/Rückmeldung geben| Ausgabe, ob Zahl richtig ist, Rückmeldung ausgeben|
| 1.3  |Spiel ausgeführt, Zahl eingegeben| Warten nach eingabe von Zahl auf Rückmeldung | Erhalten von Rückmeldung, ob Zahl richtig ist|

### 1.4 Diagramme

![grafik](https://user-images.githubusercontent.com/110892351/186116210-84b1487f-cdf9-493f-9333-d1eac3e26092.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 2.A  |  13.9.22     |Salma Tanner| Erstellen von zufälligen Zahlengenerator|45 Min|
| 1.A  |  13.9.22     |Salma Tanner| Erstellen von Benutzereingaben für Zahl|45 Min|
| 2.B  |  13.9.22     |Salma Tanner| Erstellen von Kontrolle für Benutzerzahl/Rückmeldung |45 Min|
| 3.A  |  13.9.22     |Salma Tanner| Ausgabe von Rückmeldung an Benutzer|45 Min|
Total: 3h

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

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
