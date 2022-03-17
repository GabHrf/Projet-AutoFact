# AutoFact

- CONTEXTE: 
  - Le site autoentrepreneur.fr existe depuis 2011 et s'efforce d'offrir toujours plus de 
services à ses clients. Nous avons notamment mis en place des exemples de factures client au format
libre office, un fichier Excel pour suivre son chiffre d'affaire mois par mois, mais nous voulions 
allez plus loin suite à de nombreuses demandes de nos visiteurs en simplifiant et en regroupant ces 
"mini services" dans un seul et même outil. En 2019 le site a donc décidé de créer un logiciel pour 
les auto-entrepreneurs afin de leur simplifier encore plus la gestion de leur entreprise en sachant que
cela n'est souvent pas leur cœur de métier.

- DESCRIPTION DE LA DEMANDE:
  - AutoFact doit permettre la facturation clients des auto-entrepreneurs. L'application doit gérer
les clients (nom, prénom, adresse). Ainsi que des prestations (Description, quantité, prix unitaire, tva).
L'auto-entrepreneur doit pouvoir se connecter avec son compte et créer suivant le type : - une facture 
ou - un devis.

- PRE-REQUIS:
	- Serveur local (WAMP ou XAMPP) avec PhpMyAdmin

- CONTRIBUANTS:
  - Élèves de BTS SIO option SLAM du lycée Fulbert
    -  Gabriel Harfouche - chef de projet/développeur
  - Client: Autoentrepreneur.fr
	
- Période de réalisation : Novembre 2021 - Mai 2022

- NOTICE D'INSTALLATION:
	- Rendez-vous sur le lien suivant et téléchargez l'application au format .zip :
		github ::
	- Dézippez le fichier;
	- Aller sur phpMyAdmin de votre serveur local et créez une base de données : "solucedevautofact";
	- Aller sur la section "Importer" de la base de données, puis importer le fichier "solucedevautofact.sql" présent dans le fichier dézipper;
	- Vous pouvez lancer l'application dans Autofact\bin\Debug\Autofact.exe ;
	- Inscrivez-vous et vous pourrez commencer directement à créer des facturation pour vos clients !
