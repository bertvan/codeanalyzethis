using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EnvDTE80;
using EnvDTE;

namespace CodeAnalyzeThis
{
    public partial class Form1 : Form
    {

        List<string> alteredProjects = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        public Solution2 CurrentSolution { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            disableButton.Enabled = true;
            restoreButton.Enabled = false;
        }

        private void disableButton_Click(object sender, EventArgs e)
        {

            alteredProjects.Clear();

            disableButton.Enabled = false;
            restoreButton.Enabled = true;

            for (int i = 1; i <= CurrentSolution.Projects.Count; i++)
            {
                disableCodeAnalysis(CurrentSolution.Projects.Item(i));
            }

        }
        
        private void disableCodeAnalysis(Project project)
        {

            if (project.Kind == "{66A26720-8FB5-11D2-AA7E-00C04F688DDE}")
            {
                foreach (ProjectItem subProject in project.ProjectItems)
                {
                    if(subProject.Object as Project != null)
                        disableCodeAnalysis((Project)subProject.Object);
                }

                return;
            }

            foreach (Property item in project.ConfigurationManager.ActiveConfiguration.Properties)
            {

                if (item.Name != "RunCodeAnalysis")
                    continue;

                bool fxCopWasEnabled = (bool)item.Value;

                if (!fxCopWasEnabled)
                    break;

                alteredProjects.Add(project.UniqueName);

                item.Value = false;

                break;

            }

                
            
        }

        private void enableCodeAnalysis(Project project)
        {

            if (project.Kind == "{66A26720-8FB5-11D2-AA7E-00C04F688DDE}")
            {
                foreach (ProjectItem subProject in project.ProjectItems)
                {
                    if (subProject.Object as Project != null)
                        enableCodeAnalysis((Project)subProject.Object);
                }
            }

            if(!alteredProjects.Contains(project.UniqueName))
                return;

            foreach (Property item in project.ConfigurationManager.ActiveConfiguration.Properties)
            {

                if (item.Name != "RunCodeAnalysis")
                    continue;

                item.Value = true;
            
                break;

            }



        }


        private void restoreButton_Click(object sender, EventArgs e)
        {
            disableButton.Enabled = true;
            restoreButton.Enabled = false;

            foreach (Project project in CurrentSolution.Projects)
            {
                enableCodeAnalysis(project);
            }
            

        }

    }
}