class Main{
    static doWork(){
        const names = ["Jenifer", "John", "Abby", "Bailey", "Rian"];
        const actions =["set new visualisation", "prepare new template", "upload new file", "download file from existing source", " receive an error after action xyz"];
        setInterval(function(){
            let name = names[Math.floor(Math.random() * names.length)];
            let action =actions[Math.floor(Math.random() * actions.length)];
            console.log(`${name} ${action}`);
        }, 2500);
    }
}

Main.doWork();