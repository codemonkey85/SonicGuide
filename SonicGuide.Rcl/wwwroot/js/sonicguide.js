const synth = window.speechSynthesis;

export function speakText(text) {
    if (synth.speaking) {
        console.error("speechSynthesis.speaking");
        return;
    }

    if (text !== "") {
        const utterThis = new SpeechSynthesisUtterance(text);
        synth.speak(utterThis);
    }
}
