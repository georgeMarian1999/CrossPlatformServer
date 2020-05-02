using Problem11.Model;
using Problem11.Repositories;
using System;
using System.Collections.Generic;

namespace Problem11.Service
{
    public class Service
    {
        public AngajatRepository angajati { get; set; }
        public CursaRepository curse { get; set; }
        public EchipaRepository echipe { get; set; }
        public InscriereRepository inscrieri { get; set; }
        public ParticipantRepository participanti { get; set; }
        public Service(AngajatRepository angajatRepository,CursaRepository cursaRepository,EchipaRepository echipaRepository,InscriereRepository inscriereRepository,ParticipantRepository participantRepository)
        {
            this.angajati = angajatRepository;
            this.curse = cursaRepository;
            this.echipe = echipaRepository;
            this.inscrieri = inscriereRepository;
            this.participanti = participantRepository;
        }
        public List<Angajat> getAllEmployees()
        {
            return this.angajati.findAll();
        }
        public void AddAngajat(Angajat angajat)
        {
            this.angajati.save(angajat);
        }
        public void AddCursa(Cursa cursa)
        {
            this.curse.save(cursa);
        }
        public void AddEchipa(Echipa echipa)
        {
            this.echipe.save(echipa);
        }
        public void AddInscriere(Inscriere inscriere)
        {
            this.inscrieri.save(inscriere);

        }
        public void AddParticipant(Participant participant)
        {
            this.participanti.save(participant);
        }
        public bool LocalLogin(String user,String pass)
        {
            return this.angajati.LocalLogin(user, pass);
        }
        public List<DTOBJCursa> GroupByCapacitate()
        {
            return this.curse.GroupByCapacitate();
        }
        public List<DTOBJPart> cautare(String numeEchipa)
        {
            return this.echipe.cautare(numeEchipa);
        }

        public List<string> getAllTeams()
        {
            return this.echipe.findAll();
        }
        public void InscrirereParticipant(int capacitate,String numeParticipant,String numeEchipa)
        {
            int idCursa, idParticipant, idEchipa, idInscriere;
            idCursa = this.curse.findIdByCapacitate(capacitate);
            idEchipa = this.echipe.FindIdByName(numeEchipa);
            idParticipant = this.participanti.FindMaxId() + 1;
            idInscriere = this.inscrieri.FindMaxId() + 1;
            Participant nou = new Participant(idParticipant, numeParticipant, idEchipa);
            this.AddParticipant(nou);
            Inscriere noua = new Inscriere(idInscriere, idParticipant, idCursa);
            this.AddInscriere(noua);
        }
        
    }
}
