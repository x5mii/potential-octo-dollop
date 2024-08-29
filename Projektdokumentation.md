# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

✍️ Ihr Gruppenname und Ihre Nachnamen

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

✍️ Beschreiben Sie Ihr Projekt in einem griffigen Satz.

### 1.2 User Stories

| Nr. | Verbindlichkeit | Typ        | Beschreibung |
| --- | --------------- | ---------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 1   | Muss            | Funktional | Als User möchte ich Dinge wie Jahresgewinn, ges. Reserven, Aktien-und Partizipationskapital usw. Eingeben können, um die Gewinnverteilung korrekt berechnen zu können.           |
| 2   | Muss            | Funktional | Als User möchte ich, dass die Applikation den Beitrag zur ges. Reserve, den Betrag der Dividende und den Gewinn- oder Verlustvortrag für die nächste Rechnung berechnet, damit ich die richtigen Werte erhalte. |
| 3   | Muss            | Qualität   | Als User möchte ich, dass die Applikation die Eingaben auf Plausibilität prüft, damit ich sicherstellen kann, dass alle Werte gültig sind und keine Berechnungsfehler aufgetreten sind. |
| 4   | Muss            | Qualität   | Als User möchte ich hilfreiche Fehlermeldungen erhalten, wenn ich falsche oder invalide Werte eingebe, damit ich die Eingaben korrigieren kann.                                    |
| 5   | Kann            | Funktional | Als User möchte ich, dass die Applikation die berechneten Ergebnisse erklärt, damit ich verstehe, wie man auf die Werte kommt.                                                    |
| 6   | Muss            | Rand       | Als User möchte ich wissen, dass Agio, Tantiemen und Verfahren für eine Holding nicht berücksichtigt werden, damit ich die Berechnungen korrekt verstehen kann.                     |
| 7   | Kann            | Rand       | Als User möchte ich, dass die Berechnungen der ges. Gewinnreserve und Dividende korrekt durchgeführt werden, ohne die Berücksichtigung von Dingen wie Agio und Tantiemen.         |

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |              |         |                   |
| ...  |              |         |                   |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |           |              |               |
| ...  |       |           |              |               |

Total: 

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
