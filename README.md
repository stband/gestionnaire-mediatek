# Gestion du Personnel MediaTek86

## Description

Ce projet consiste à développer une application de bureau pour la gestion du personnel d'une médiathèque. L'application permet de gérer les informations sur le personnel, leurs absences, et les services associés. 

## Fonctionnalités

- Gestion des informations du personnel
- Gestion des absences du personnel
- Gestion des services associés

## Technologies Utilisées

- **Langage de programmation** : C#
- **Base de données** : MySQL
- **IDE** : Visual Studio 2022
- **Framework** : .NET
- **Installation** : Setup avec WiX Toolset

## Installation

### Prérequis

- MySQL doit être installé et configuré.

### Étapes

#### Cloner de dépôt

1. Clonez le dépôt GitHub :
    ```sh
    git clone https://github.com/stband/GestionnaireMediatek.git
    ```
2. Ouvrez la solution dans Visual Studio 2022.
3. Exécutez le script SQL pour créer la base de données et les tables nécessaires.
4. Générez la solution dans Visual Studio.

### Utilisation de l'Installeur

1. Téléchargez l'installeur depuis le dépôt GitHub :
    - [Télécharger l'Installeur](Installer/setupmediatek.exe)
2. Exécutez le fichier `setupmediatek.exe` pour lancer l'assistant d'installation.
3. Suivez les étapes de l'assistant pour installer l'application sur votre poste.
    - Sélectionnez le répertoire d'installation.
    - Choisissez les options par défaut ou personnalisez l'installation selon vos besoins.
    - Cliquez sur "Installer" pour commencer l'installation.
4. Une fois l'installation terminée, vous trouverez un raccourci vers l'application sur le bureau et dans le menu Démarrer.

### Configuration de la Base de Données

1. Ouvrez un SGBD pour MySql.
2. Exécutez le script SQL fourni pour créer la base de données et les tables :
    - [Script SQL](mediatek86SQL.sql)
3. Assurez-vous que l'utilisateur MySQL a les droits d'accès appropriés à la base de données.

## Utilisation

1. Lancez l'application via le raccourci sur le bureau ou depuis le menu Démarrer.
2. Connectez-vous avec les identifiants fournis.
3. Utilisez les différentes fonctionnalités de l'application pour gérer le personnel, les absences, et les services.

## Documentation Technique

La documentation technique de l'application est disponible dans le répertoire `Docs`. Vous pouvez la consulter pour obtenir des détails sur les classes, les méthodes et les fonctionnalités de l'application.

- [Documentation Technique HTML](Docs/html/annotated.html)

## Auteur

- **Nom** : stband

