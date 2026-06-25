string input = txtInput.Text.ToLower();

if (input.Contains("password"))
{
    txtChat.AppendText("Bot: Use strong passwords.\n");
}
else if (input.Contains("phishing"))
{
    txtChat.AppendText("Bot: Never click suspicious links.\n");
}
else if (input.Contains("privacy"))
{
    txtChat.AppendText("Bot: Review your privacy settings regularly.\n");
}
else
{
    txtChat.AppendText("Bot: I don't understand.\n");
}

txtInput.Clear();