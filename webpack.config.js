const path = require("path");
const MiniCssExtractPlugin = require("mini-css-extract-plugin");

module.exports = {
    mode: "development",
    entry: {
        editor: "./src/edit.tsx",
        runner: "./src/run.tsx"
    },
    output: {
        path: path.resolve(__dirname, "./wwwroot/static/js"),
        filename: "[name].js"
    },
    resolve: { extensions: [".ts", ".js", ".jsx", ".tsx"] },
    module: {
        rules: [
            {
                test: /\.ts|\.tsx$/,
                use: [{ loader: "babel-loader", options: { "presets": ["@babel/preset-env", "@babel/preset-react", "@babel/preset-typescript"] } }]
            },
            {
                test: /\.css$/,
                use: [
                    MiniCssExtractPlugin.loader,
                    {
                        loader: "css-loader",
                        options: {
                            sourceMap: false,
                        },
                    },
                ],
            },
            {
                test: /\.s(c|a)ss$/,
                use: [
                    MiniCssExtractPlugin.loader,
                    {
                        loader: "css-loader",
                        options: {
                            sourceMap: false,
                        },
                    },
                    {
                        loader: "sass-loader",
                        options: {
                            sourceMap: false,
                        },
                    },
                ],
            },
        ]
    },
    plugins: [
        new MiniCssExtractPlugin({ filename: "[name].css" })
    ],
};