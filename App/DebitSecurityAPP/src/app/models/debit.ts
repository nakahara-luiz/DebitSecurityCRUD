import { Installment } from "./installment";

export class Debit {
  Penalty!: number;
  Interest!: number;
  NumberInstalments!: number;
  OriginalValue!: number;
  DaysOverdue!: number;
  ActualValue!: number;
  Installments!: Installment[];
  DocumentId!: number;
  Id!: number;
}
