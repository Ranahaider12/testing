import { testingTemplatePage } from './app.po';

describe('testing App', function() {
  let page: testingTemplatePage;

  beforeEach(() => {
    page = new testingTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
