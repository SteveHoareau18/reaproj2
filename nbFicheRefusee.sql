CREATE TRIGGER `nbFicheRefusee` 
AFTER DELETE ON `lignefraishorsforfait` 
FOR EACH ROW 
UPDATE comptable
SET comptable.nbFicheRefusee = comptable.nbFicheRefusee+1 
WHERE comptable.idUtilisateur = lignefraishorsforfait.idVisiteur;