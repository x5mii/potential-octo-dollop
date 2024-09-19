# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

Potential-octo-dollop Samuel Lucena, Alberto Manser, Julius Burlet, Timo Goedertier

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 15.08.24| 0.0.1   | User-Stories und planen erstellt  |
| 22.08.24| 0.0.2   | Entwicklungsumgebung aufgesetzt, User-Stories fertiggestellt und Testfälle erstellt|
| 29.08.24| 0.0.3 | Grundfunktionalitäten der Berechnungen erstellt und GUI erstellt |
| 5.09.24 | 0.1.0 | Fertigstellen GUI und BErechnungslogik, zusammenführen GUI und Logik |
| 12.09.24| 1.0.0   | Erfolgreich getestet und Code von Bugs bereinigt|
| 19.09.24| 1.0.0 | Präsentation erstellt |


## 1 Informieren

### 1.1 Ihr Projekt

Unser Projekt ist ein Finanzrechner welcher die vom User getätigten Eingaben laut OR Art. 671 korrekt durchrechnet und die Auszuschüttende Dividende inklusive aller Abzüge ausgibt.

### 1.2 User Stories

| Nr. | Verbindlichkeit | Typ | Beschreibung |
| --- | --------------- | --- | ------------ |
| 1   | Muss| Funktional | Als User möchte ich Dinge wie Jahresgewinn, ges. Reserven, Aktien-und Partizipationskapital usw. Eingeben können, um die Gewinnverteilung korrekt berechnen zu können.|
| 2   | Muss| Funktional | Als User möchte ich, dass die Applikation den Beitrag zur ges. Reserve, den Betrag der Dividende und den Gewinn- oder Verlustvortrag für die nächste Rechnung berechnet, damit ich die richtigen Werte erhalte. |
| 3   | Muss| Qualität   | Als User möchte ich, dass die Applikation die Eingaben auf Plausibilität prüft, damit ich sicherstellen kann, dass alle Werte gültig sind und keine Berechnungsfehler aufgetreten sind. |
| 4   | Muss| Qualität   | Als User möchte ich hilfreiche Fehlermeldungen erhalten, wenn ich falsche oder invalide Werte eingebe, damit ich die Eingaben korrigieren kann.|
| 5   | Kann| Funktional | Als User möchte ich, dass die Applikation die berechneten Ergebnisse erklärt, damit ich verstehe, wie man auf die Werte kommt.|
| 6   | Muss| Rand| Als User möchte ich wissen, dass Agio, Tantiemen und Verfahren für eine Holding nicht berücksichtigt werden, damit ich die Berechnungen korrekt verstehen kann.|
| 7   | Kann| Rand| Als User möchte ich, dass die Berechnungen der ges. Gewinnreserve und Dividende korrekt durchgeführt werden, ohne die Berücksichtigung von Dingen wie Agio und Tantiemen.|

### 1.3 Testfälle

| TC-№ | Ausgangslage| Eingabe | Erwartete Ausgabe |
| ---- | ----------- | ------- | ----------------- |
| 1.1  | Die Applikation ist gestartet, der Benutzer möchte Jahresgewinn, ges. Reserven und Kapitalwerte eingeben. | Jahresgewinn: 500.000, ges. Reserven: 1.000.000, Aktienkapital: 2.000.000| Die Werte werden gespeichert, und der Benutzer kann auf den nächsten Berechnungsschritt gehen.|
| 1.2  | Der Benutzer hat alle relevanten Werte eingegeben.| Klick auf "Berechnen"| Die Applikation berechnet den Beitrag zur ges. Reserve, Dividende und den Gewinn- oder Verlustvortrag und zeigt die Werte an.|
| 1.3  | Der Benutzer gibt einen nicht plausiblen Wert ein (z. B. negative Dividende).| Jahresgewinn: 500.000, Dividende: -100.000| Die Applikation gibt eine Fehlermeldung aus, dass der Wert nicht plausibel ist.|
| 1.4  | Der Benutzer gibt einen falschen Wert ein (z. B. Buchstaben anstelle von Zahlen).| Jahresgewinn: "abc", ges. Reserven: 1.000.000, Aktienkapital: 2.000.000| Die Applikation gibt eine Fehlermeldung aus, dass die Eingabe ungültig ist.|
| 1.5  | Der Benutzer hat falsche oder invalide Werte eingegeben.| Jahresgewinn: "abc", Dividende: 100.000| Die Applikation gibt eine spezifische Fehlermeldung, die dem Benutzer hilft, die Werte zu korrigieren (z. B. "Jahresgewinn muss eine Zahl sein").|
| 1.6  | Der Benutzer möchte verstehen, wie die Werte berechnet wurden.| Klick auf "Erklärung anzeigen"| Die Applikation zeigt eine Erklärung der Berechnungsschritte an (z. B. "Dividende = 10 % des Jahresgewinns").|
| 1.7  | Der Benutzer möchte sicherstellen, dass Agio, Tantiemen und Holding-Verfahren nicht berücksichtigt werden. | Jahresgewinn: 500.000, ges. Reserven: 1.000.000, Aktienkapital: 2.000.000| Die Applikation führt die Berechnungen ohne Berücksichtigung von Agio, Tantiemen und Holding-Verfahren durch und zeigt eine Bestätigung darüber an.|
| 1.8  | Der Benutzer möchte die Berechnung der ges. Gewinnreserve und Dividende ohne Agio und Tantiemen sehen. | Jahresgewinn: 500.000, ges. Reserven: 1.000.000, Aktienkapital: 2.000.000| Die Berechnung erfolgt korrekt ohne Berücksichtigung von Agio und Tantiemen, und die Werte für Gewinnreserve und Dividende werden korrekt angezeigt.|


### 1.4 Diagramme


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 15.10.2024  | Entwickler-Team   | Als User möchte ich Dinge wie Jahresgewinn, ges. Reserven, Aktien-und Partizipationskapital usw. eingeben können, um die Gewinnverteilung korrekt berechnen zu können. | 5 Tage|
| 1.B  | 20.10.2024  | Entwickler-Team   | Als User möchte ich, dass die Applikation den Beitrag zur ges. Reserve, den Betrag der Dividende und den Gewinn- oder Verlustvortrag für die nächste Rechnung berechnet, damit ich die richtigen Werte erhalte. | 7 Tage|
| 1.C  | 25.10.2024  | QA-Team| Als User möchte ich, dass die Applikation die Eingaben auf Plausibilität prüft, damit ich sicherstellen kann, dass alle Werte gültig sind und keine Berechnungsfehler aufgetreten sind. | 3 Tage|
| 1.D  | 28.10.2024  | QA-Team| Als User möchte ich hilfreiche Fehlermeldungen erhalten, wenn ich falsche oder invalide Werte eingebe, damit ich die Eingaben korrigieren kann. | 3 Tage|
| 1.E  | 01.11.2024  | Entwickler-Team   | Als User möchte ich, dass die Applikation die berechneten Ergebnisse erklärt, damit ich verstehe, wie man auf die Werte kommt. | 4 Tage|
| 1.F  | 05.11.2024  | Entwickler-Team   | Als User möchte ich wissen, dass Agio, Tantiemen und Verfahren für eine Holding nicht berücksichtigt werden, damit ich die Berechnungen korrekt verstehen kann. | 2 Tage|
| 1.G  | 08.11.2024  | Entwickler-Team   | Als User möchte ich, dass die Berechnungen der ges. Gewinnreserve und Dividende korrekt durchgeführt werden, ohne die Berücksichtigung von Dingen wie Agio und Tantiemen. | 3 Tage|


## 3 Entscheiden



## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | .10.2024| Entwicckler-Team|5 Tage               |4 Tage                   |
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
