import alt from 'alt-client';
const list = [];
class KeyHandler {
    constructor(key, code, func) {
        this.key = key;
        this.code = code;
        this.func = func;
        list.push(this);
    }
}
alt.on("keydown", key => {
    for (const handler of list) {
        if (handler.code != key)
            continue;
        if (!handler.func)
            alt.emitServer(`KeyPress${handler.key}`);
        else if (handler.func())
            break;
    }
});
export default KeyHandler;
