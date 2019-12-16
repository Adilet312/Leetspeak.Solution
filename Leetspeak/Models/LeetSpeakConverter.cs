using System;
namespace LeetspeakConvertor
{
    public class LeetspeakTranslator
    {
        private string words;
        public LeetspeakTranslator(string words)
        {
            this.words = words;
        }
        public string GetWords()
        {
            return this.words;
        }

        public void SetWords(string new_word)
        {
            this.words = new_word;
        }

        public string Translate()
        {
            string new_string = "";
            //char [] array_without_translator = this.words.ToCharArray();
            //char [] array_with_translator = 
            for (int idx = 0; idx < this.words.Length; idx++)
            {
                if(this.words[idx]=='e' || this.words[idx]=='E')
                {
                    new_string+='3';
                }
                else if(this.words[idx]=='o' || this.words[idx]=='O')
                {
                    new_string+='0';
                }
                else if(this.words[idx]=='t' || this.words[idx]=='T')
                {
                    new_string+='7';
                }
                else if(this.words[idx]=='s' || this.words[idx]=='S')
                {
                    new_string+='z';
                }
                else if (this.words[idx]=='I')
                {
                    new_string+='1';
                }
                else
                {
                    new_string+=this.words[idx];
                }
            }
            return new_string;
        }
        public string PrintWord()
        {
            return "Given word is "+this.words;
        }

    }
}