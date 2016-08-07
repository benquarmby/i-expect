"use strict";

var gulp = require("gulp");
var cp = require("child_process");
var fs = require("fs-extra-promise");
var Promise = require("bluebird");

function spawnAsync(command, args, options) {
    options = options || {
        stdio: "inherit"
    };

    return new Promise(function (resolve, reject) {
        cp.spawn(command, args, options)
            .on("close", function (code) {
                if (code) {
                    return reject(new Error("Command failed with code " + code));
                }

                resolve();
            })
            .on("error", reject);
    });
}

gulp.task("default");

gulp.task("build", function () {
    return Promise
        .try(function () {
            return fs.ensureDirAsync("../publish");
        })
        .then(function () {
            var command = "../packages/NuGet.CommandLine.3.4.3/tools/NuGet.exe";
            var args = [
                "pack",
                "../source/IExpect/IExpect.csproj",
                "-Build",
                "-Properties", "Configuration=Release",
                "-OutputDirectory", "../publish"
            ];

            return spawnAsync(command, args);
        });
});
