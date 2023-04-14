using DesignPatternASP.DesignPattern.AbstractFactory;
using System;

namespace DesignPatternASP.DesignPattern.Memento
{
    public class Survey
    {
        private SurveyState state;

        public Survey(SurveyState state) 
        { 
            this.state = state;
        }

        public SurveySnapshot CreateSnapshot() 
        {
            SurveySnapshot surveySnapshot = new SurveySnapshot(AppSettings.LogFilePath);
            surveySnapshot.Save(this.state);
            return surveySnapshot;
        }

        public void RestoreSnapshot(SurveySnapshot snapshot)
        {
            this.state = snapshot.Restore();
        }

        public List<string> GetAnswers()
        {
            return this.state.Answers;
        }

        public void Submit()
        {
            
        }
    }
}
