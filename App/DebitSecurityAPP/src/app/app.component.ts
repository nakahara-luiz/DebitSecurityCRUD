import { Component } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'DebitSecurityAPP';

  constructor(
    private translate: TranslateService,
  ) {
    this.translate.addLangs(["pt"]);
    let browserLang = this.translate.getBrowserLang();
    this.translate.use(browserLang);
  }
}
