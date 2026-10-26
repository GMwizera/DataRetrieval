# DataRetrieval

Unity 6 project for the Data Storage and Retrieval class activity.

## Scripts

- `PlayerData` - ScriptableObject with a name, level, speed and color.
- `PlayerDataDisplay` - shows the PlayerData values in the UI and spins the cube using speed.
- `PrefsManager` - saves/loads name (string), score (int) and play time (float) with PlayerPrefs.
- `ItemData` / `ItemDisplay` - bonus, 4 items with a title and icon.

## Testing

Open `SampleScene` and press Play. Type a name, add some score and click Save. Stop and play again and the values come back. Reset clears everything.

For the bonus open `DataStorage` and press Play.

Screenshots are in the `Screenshots` folder.
