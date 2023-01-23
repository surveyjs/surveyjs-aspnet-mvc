const path = require("path");

module.exports = {
    mode: "development",
    entry: { main: "./src/app.tsx" },
    output: {
        path: path.resolve(__dirname, "./wwwroot/static/js"),
        filename: "site.js"
    },
    resolve: { extensions: [".ts", ".js", ".jsx", ".tsx"] },
    module: {
        rules: [
            {
                test: /\.ts|\.tsx$/,
                use: [{ loader: "babel-loader", options: { "presets": ["@babel/preset-env", "@babel/preset-react", "@babel/preset-typescript"] } }]
            }]
    }
};