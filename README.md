# XBSwap

XBSwap is a simple automation tool for an annoying feature Windows games do, where when you go to sign out and switch accounts.

This blocks a few services in registry to allow you to boot the game of your choice, swap accounts and revert changes.

Stupid I even had to make something like this. Thank you M$


How do XBSwap

- Sign out completely or switch accounts to whatever XBL account you want to play on.
- Start the tool.
- When it says the services are blocked, start the game and you will be prompted to sign in. (Or if you swapped prior it will run normally)
- Once in game and you've confirmed the account has swapped, follow the prompt that says "Press any key....."
- The console window should then say it's unblocked the servies and you are all set.

Again thank you M$, without you I wouldn't make such a pointless tool :)


-Added PID killing. Forgot to kill all associated PID's prior to blocking services. Tool should be functional now.
