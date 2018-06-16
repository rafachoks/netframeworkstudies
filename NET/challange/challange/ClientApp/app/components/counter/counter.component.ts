import { Component } from '@angular/core';

@Component({
    selector: 'counter',
    templateUrl: './counter.component.html'
})
export class CounterComponent {
    public currentCount = 0;

    public incrementCounter() {
        var value = ((document.getElementById("text") as HTMLInputElement).value);
        this.currentCount++;
        var regex = /\s+/gi;
        var wordCount = value.trim().replace(regex, ' ').split(' ').length;

        
    }
}
