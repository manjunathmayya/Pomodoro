#%%
import pandas as pd

#%%

data = pd.read_csv('C:\\pomodoro_log_file.txt', delimiter=';', header=None)

# data = data[data[3].str.contains("Start")| data[3].str.contains("Paused") | data[3].str.contains("Stopped")]

newdata = data.fillna(0).groupby([2]).sum()

print(data)
# data.to_csv('pomo_test.csv')
# %%
