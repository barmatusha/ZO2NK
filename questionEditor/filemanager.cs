using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionEditor
{
    class CFileManager
    {
        static string mFilePath;
        public static List<question> mFileData;
         
        static CFileManager()
        {
            mFileData = new List<question>();
        }
        public static void LoadFile(string path)
        {
            mFilePath = path;
            string[] tmpLines;
            tmpLines = File.ReadAllLines(path);
            for (int i = 0; i < tmpLines.Length; i++)
            {
                string[] tmpLine = tmpLines[i].Split('|');
                try
                {
                    question _question = new question();
                    _question.typeOfDifficult = int.Parse(tmpLine[0]);
                    _question.mTitle = tmpLine[1];
                    _question.mAnswer = tmpLine[2];
                    _question.mRezult = int.Parse(tmpLine[3]);
                    _question._mRezult = (_question.mRezult == 0) ? "ложь" : "истина"; 
                    mFileData.Add(_question);
                } catch {}
            }
        }
        public static void removeQuestion(question q)
        {
            mFileData.Remove(q);
            Save();
        }
        public static void updateQuestion(int idx, question q)
        {
            mFileData[idx] = q;
            Save();
        }
        public static void appendQuestion(question q)
        {
            mFileData.Add(q);
            Save();
        }

        public static void Save()
        {
            string[] stringLinez = new string[mFileData.Count];
            for (int i = 0; i < stringLinez.Length; i++)
            {
                stringLinez[i] = mFileData[i].ToString();
            }
            File.WriteAllLines(mFilePath, stringLinez);
        }
    }
}
