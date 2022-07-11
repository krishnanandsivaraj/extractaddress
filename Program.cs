// See https://aka.ms/new-console-template for more information
        string[] lines = System.IO.File.ReadAllLines(@"input.txt");
        string[] output = new string[lines.Length+1];
        int i = 0;
        foreach (string line in lines)
        {
            // Use a tab to indent each line of the file.
            // Console.WriteLine("\t" + line);
            var temp = line.Split(" ");
            var o = new List<string>();
            bool flag = false;
            string result = "";

            foreach(var t in temp){
                            if(flag){o.Add(t);}
                if(t.Contains(":") || t == "is" || t =="at"){
                    flag = true;
                    i++;
                }

            }
            if(!flag){ o.Add(line); }

            result = String.Join(" ", o.ToArray());
                Console.WriteLine(result.Replace(", Thank You ", "").Replace("Thank You ", "").Replace("Thank", "").Replace("You", "").Replace("at", "").Trim());            
        }

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();
