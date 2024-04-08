const fs = require("fs");
const path = require("path");

const extensions = {
  rar: "rar",
  docx: "docx",
  jpg: "jpg",
  png: "png",
  ico: "ico",
  mp4: "mp4",
  avi: "avi",
  mk4: "mk4",
};

const source = "/home/wilson/Downloads";

const dest1 = "/home/wilson/Documents/";
const dest2 = "/home/wilson/Pictures/";
const dest3 = "/home/wilson/Videos/";

/**
 *
 * @param {*} sourceFile The path to the source file
 * @param {*} destination The path to the destionation directory
 */

function moveFile(sourceFile, destination) {
  const fileName = path.basename(sourceFile);
  const destinationFile = path.join(destination, fileName);
  fs.renameSync(sourceFile, destinationFile);
}

for (const extension in extensions) {
  const files = fs
    .readdirSync(source)
    .filter((file) => file.endsWith(`.${extension}`));

  files.forEach((file) => {
    if (["rar", "docx"].includes(extension)) {
      moveFile(path.join(source, file), dest1);
    } else if (["jpg", "png", "ico"].includes(extension)) {
      moveFile(path.join(source, file), dest2);
    } else if (["mp4", "avi", "mk4"].includes(extension)) {
      moveFile(path.join(source, file), dest3);
    }
  });
}
