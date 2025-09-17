import json
import re

file_path = r"C:\Users\tarik\Desktop\Fantasy Matchup\backend\FootballFantasyMatchup\fm_players.json"

def extract_rating(rating_str: str) -> float:
    # Pronađi prvi broj (može imati zarez ili tačku)
    match = re.search(r"\d+([.,]\d+)?", rating_str)
    if match:
        return float(match.group(0).replace(",", "."))
    return 0.0

# Učitaj postojeći JSON
with open(file_path, "r", encoding="utf-8") as f:
    players = json.load(f)

# Očisti rating za svakog igrača
for player in players:
    if "rating" in player:
        player["rating"] = extract_rating(player["rating"])

# Snimi nazad u isti fajl (overwrite)
with open(file_path, "w", encoding="utf-8") as f:
    json.dump(players, f, ensure_ascii=False, indent=2)

print(f"File overwritten successfully: {file_path}")
