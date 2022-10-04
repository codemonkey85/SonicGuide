export function speakText(text) {
    if ('speechSynthesis' in window) {
    } else {
        alert("Sorry, your browser doesn't support text to speech!");
        return;
    }
    var msg = new SpeechSynthesisUtterance();
    msg.text = text;
    window.speechSynthesis.speak(msg);
}
