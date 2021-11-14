﻿using AwarenessWebApp.DTO;
using System.Collections.Generic;
using System.Text.Json;

namespace AwarenessWebApp
{
    public class UserState
    {
        public string UserName;
        public ProcedureDTO CurrentProcedureDTO = new();
        public MedicDTO LoggedMedic = new();
        public List<BtnGroupItem> ProcedureSteps = new();
        public string UpdateProfileMsg;
        public string CurrentStep;
        public string Url_hololens_service;
        public string Url_monitor_service;
        public UserState()
        {
            this.constructProcedureSteps("", "disabled");
            this.setConfiguration();
        }
        public void resetData()
        {
            this.CurrentProcedureDTO = new();
            this.constructProcedureSteps("", "disabled");
        }

        public void setConfiguration()
        {
            Url_hololens_service = "https://hololenscommunicationserviceawareness.azurewebsites.net/api/hololens-communication-service";
            Url_monitor_service = "https://awarenessmonitorscomunication.azurewebsites.net";
        }

        public void stringResponseJsonConvertMedic(string jsonString)
        {
            this.LoggedMedic = JsonSerializer.Deserialize<MedicDTO>(jsonString);
        }
        private void constructProcedureSteps(string enabled, string disabled)
        {
            this.ProcedureSteps.Clear();
            BtnGroupItem enterPatientData = new();
            BtnGroupItem enterProcedureData = new();
            BtnGroupItem monitorConnection = new();
            BtnGroupItem hololensConnection = new();
            BtnGroupItem beginProcedure = new();
            BtnGroupItem procedureInProgress = new();

            enterPatientData.reference = "enterPatientData";
            enterPatientData.status = enabled;
            enterPatientData.msg = "Ingresar Datos del Paciente";
            enterPatientData.active = "active";

            enterProcedureData.reference = "enterProcedureData";
            enterProcedureData.status = enabled;
            enterProcedureData.msg = "Ingresar Datos Procedimiento";
            enterProcedureData.active = "";

            monitorConnection.reference = "monitorConnection";
            monitorConnection.status = disabled;
            monitorConnection.msg = "Conexión con Monitor";
            monitorConnection.active = "";

            hololensConnection.reference = "hololensConnection";
            hololensConnection.status = disabled;
            hololensConnection.msg = "Conexión con Gafas";
            hololensConnection.active = "";

            beginProcedure.reference = "beginProcedure";
            beginProcedure.status = disabled;
            beginProcedure.msg = "Iniciar Procedimiento";
            beginProcedure.active = "";

            procedureInProgress.reference = "inProgressProcedure";
            procedureInProgress.status = disabled;
            procedureInProgress.msg = "Procedimiento en curso";
            procedureInProgress.active = "";

            this.ProcedureSteps.Add(enterPatientData);
            this.ProcedureSteps.Add(enterProcedureData);
            this.ProcedureSteps.Add(monitorConnection);
            this.ProcedureSteps.Add(hololensConnection);
            this.ProcedureSteps.Add(beginProcedure);
            this.ProcedureSteps.Add(procedureInProgress);
        }
        public void nextStepActive(int current_step)
        {
            foreach (var step in this.ProcedureSteps)
            {
                step.active = "";
            }
            this.ProcedureSteps[current_step].active = "active";
        }
        public void onlyCurrentStep(int current_step)
        {
            foreach (var step in this.ProcedureSteps)
            {
                step.active = "";
                step.status = "disabled";
            }
            this.ProcedureSteps[current_step].active = "active";
            this.ProcedureSteps[current_step].status = "";
        }
    }
    public class BtnGroupItem
    {
        public string reference;
        public string status;
        public string msg;
        public string active;
    }
}
